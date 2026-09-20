using System;
using System.Collections.Generic;
using System.Text;
using CloneDallasBurger.Modelo.Entidades;
using System.Threading.Tasks;

namespace CloneDallasBurger.Modelo.Interfaces
{
    public interface IProdutoRepositorio
    {
        public Task<Produto?> ObterProdutoPorIdAsync(int Id);
        public Task<Produto> CriarProdutoAsync(Produto produto);
        public Task<List<Produto>> ObterTodosProdutosAsync();
        public Task<Produto> AtualizarProdutoAsync(Produto produto);
        public Task<Produto?> DeletarProdutoAsync(int Id);
        public Task<List<Produto>> ObterProdutosPorCategoriaAsync(int categoriaId);
    }
}
