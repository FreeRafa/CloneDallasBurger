using CloneDallasBurger.Infraestrutura.Data;
using CloneDallasBurger.Modelo.Entidades;
using CloneDallasBurger.Modelo.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CloneDallasBurger.Infraestrutura.Repositorio
{
    public class FuncionarioRepositorio : IFuncionarioRepositorio
    {
        private readonly CloneDallasBurgerContext _context;
        public FuncionarioRepositorio(CloneDallasBurgerContext context)
        {
            _context = context;
        }
        public async Task<Funcionario?> ObterFuncionarioPorIdAsync(int Id)
        {
            return await _context.Funcionarios.FindAsync(Id);
        }
        public async Task<Funcionario> CriarFuncionarioAsync(Funcionario funcionario)
        {
            _context.Funcionarios.Add(funcionario);
            await _context.SaveChangesAsync();
            return funcionario;
        }
        public async Task<List<Funcionario>> ObterTodosFuncionariosAsync()
        {
            return await _context.Funcionarios.ToListAsync();
        }
        public async Task<Funcionario> AtualizarFuncionarioAsync(Funcionario funcionario)
        {
            _context.Funcionarios.Update(funcionario);
            await _context.SaveChangesAsync();
            return funcionario;
        }
        public async Task<Funcionario?> DeletarFuncionarioAsync(int Id)
        {
            var funcionario = await _context.Funcionarios.FindAsync(Id);
            if (funcionario != null)
            {
                _context.Funcionarios.Remove(funcionario);
                await _context.SaveChangesAsync();
            }
            return funcionario;
        }

        public async Task<Funcionario?> ObterFuncionarioPorUsuarioAsync(string usuario)
        {
            return await _context.Funcionarios.FirstOrDefaultAsync(f => f.Usuario == usuario);
        }
    }
}
