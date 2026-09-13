using System;
using System.Collections.Generic;
using System.Text;
using CloneDallasBurger.Modelo.Entidades;
using System.Threading.Tasks;

namespace CloneDallasBurger.Modelo.Interfaces
{
    public interface IProdutoIngredienteRepositorio
    {
        public Task<ProdutoIngrediente> ObterProdutoIngredienteAsync(int produtoId, int ingredienteId);
        public Task<ProdutoIngrediente> CriarProdutoIngredienteAsync(ProdutoIngrediente produtoIngrediente);
        public Task<List<ProdutoIngrediente>> ObterTodosProdutosIngredientesAsync();
        public Task<ProdutoIngrediente> AtualizarProdutoIngredienteAsync(ProdutoIngrediente produtoIngrediente);
        public Task<ProdutoIngrediente> DeletarProdutoIngredienteAsync(int produtoId, int ingredienteId);
    }
}
