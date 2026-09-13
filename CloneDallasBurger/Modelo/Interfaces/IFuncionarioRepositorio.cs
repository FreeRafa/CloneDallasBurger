using System;
using System.Collections.Generic;
using System.Text;
using CloneDallasBurger.Modelo.Entidades;
using System.Threading.Tasks;

namespace CloneDallasBurger.Modelo.Interfaces
{
    public interface IFuncionarioRepositorio
    {
        public Task<Funcionario?> ObterFuncionarioPorIdAsync(int Id);
        public Task<Funcionario> CriarFuncionarioAsync(Funcionario funcionario);
        public Task<List<Funcionario>> ObterTodosFuncionariosAsync();
        public Task<Funcionario> AtualizarFuncionarioAsync(Funcionario funcionario);
        public Task<Funcionario?> DeletarFuncionarioAsync(int Id);

        // Validar funcionário por login (usuário e senha)
        public Task<Funcionario?> ObterFuncionarioPorUsuarioAsync(string usuario);
    }
}
