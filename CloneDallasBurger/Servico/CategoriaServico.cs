using CloneDallasBurger.Modelo.Entidades;
using CloneDallasBurger.Modelo.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloneDallasBurger.Servico
{
    public class CategoriaServico 
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;

        public CategoriaServico(ICategoriaRepositorio categoriaRepositorio) 
        {
            _categoriaRepositorio = categoriaRepositorio;
        }

        public async Task<Categoria?> ObterCategoriaPorIdAsync(int id) 
        {
            var existenteCat = await _categoriaRepositorio.ObterCategoriaPorIdAsync(id);

            if (existenteCat == null)
                throw new KeyNotFoundException($"Categoria com id {id} nao encontrado");

            return existenteCat;
        }

        public async Task<Categoria> CriarCategoriaAsync(Categoria categoria) 
        {
            return await _categoriaRepositorio.CriarCategoriaAsync(categoria);
        }

        public async Task<List<Categoria>> ObterTodasCategoriasAsync() 
        {
            return await _categoriaRepositorio.ObterTodasCategoriasAsync();
        }

        public async Task<Categoria> AtualizarCategoriaAsync(Categoria categoria) 
        {
            var existente = await _categoriaRepositorio.ObterCategoriaPorIdAsync(categoria.CategoriaId);

            if (existente == null)
                throw new KeyNotFoundException($"Categoria com id {categoria.CategoriaId} não encontrado.");

            return await _categoriaRepositorio.AtualizarCategoriaAsync(categoria);
        }

        public async Task<Categoria?> DeletarCategoriaAsync(int id) 
        {
            var existente = await _categoriaRepositorio.ObterCategoriaPorIdAsync(id);

            if (existente == null)
                throw new KeyNotFoundException($"Cliente com id {id} não encontrado.");

            return await _categoriaRepositorio.DeletarCategoriaAsync(id);
        }
    }
}
