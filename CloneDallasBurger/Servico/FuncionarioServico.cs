using CloneDallasBurger.Infraestrutura.Repositorio;
using CloneDallasBurger.Modelo.Entidades;
using CloneDallasBurger.Modelo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloneDallasBurger.Servico
{
    public class FuncionarioServico
    {
        private readonly IFuncionarioRepositorio _funcionarioRepositorio;

        public FuncionarioServico(IFuncionarioRepositorio funcionarioRepositorio) 
        {
            _funcionarioRepositorio = funcionarioRepositorio;
        }

        public async Task<Funcionario> ObterFuncionarioPorIdAsync(int Id) 
        {
            var funcionario = await _funcionarioRepositorio.ObterFuncionarioPorIdAsync(Id);

            if (funcionario == null)
                throw new KeyNotFoundException($"Funcionario com id {Id} nao encontrado");

            return funcionario;
        }

        public async Task<Funcionario> CriarFuncionarioAsync(Funcionario funcionario) 
        {
            return await _funcionarioRepositorio.CriarFuncionarioAsync(funcionario);
        }

        public async Task<List<Funcionario>> ObterTodosFuncionariosAsync() 
        {
            return await _funcionarioRepositorio.ObterTodosFuncionariosAsync();
        }

        public async Task<Funcionario> AtualizarFuncionarioAsync(Funcionario funcionario) 
        {
            var existente = await _funcionarioRepositorio.ObterFuncionarioPorIdAsync(funcionario.FuncionarioId);

            if(existente == null)
                throw new KeyNotFoundException($"Funcionario com id {funcionario.FuncionarioId} não encontrado.");

            return await _funcionarioRepositorio.AtualizarFuncionarioAsync(funcionario);
        }

        public async Task<Funcionario?> DeletarFuncionarioAsync(int Id) 
        {
            var existenteFunc = await _funcionarioRepositorio.ObterFuncionarioPorIdAsync(Id);

            if (existenteFunc == null)
                throw new KeyNotFoundException($"Funcionario com id {Id} não encontrado.");

            return await _funcionarioRepositorio.DeletarFuncionarioAsync(Id);
        }
    }
}
