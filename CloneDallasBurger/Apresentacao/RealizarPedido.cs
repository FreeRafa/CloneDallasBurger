using CloneDallasBurger.Servico;

namespace CloneDallasBurger.Apresentacao
{
    public class RealizarPedido
    {
        private readonly FuncionarioServico _funcionarioServico;
        private readonly MesaServico _mesaServico;

        public RealizarPedido(FuncionarioServico funcionarioServico, MesaServico mesaServico)
        {
            _funcionarioServico = funcionarioServico;
            _mesaServico = mesaServico;
        }

        public async Task IniciarPedido()
        {
            Console.WriteLine("==Iniciar o Pedido==");

            var funcionarios = await _funcionarioServico.ObterTodosFuncionariosAsync();
            foreach (var f in funcionarios)
            {
                Console.WriteLine($"{f.FuncionarioId} - {f.Nome}");
            }

            Console.Write("Escolha o numero do funcionario: ");
            int funcionarioId = int.Parse(Console.ReadLine()!);

            var mesas = await _mesaServico.ObterTodasMesasAsync();
            foreach (var m in mesas)
            {
                Console.WriteLine($"Mesa {m.Numero} - {m.Status}");
            }

            Console.Write("Escolha o numero da mesa: ");
            int mesaNumero = int.Parse(Console.ReadLine()!);

            Console.Write("Quantas pessoas na mesa: ");
            int numeroPessoas = int.Parse(Console.ReadLine()!);
        }
    }
}