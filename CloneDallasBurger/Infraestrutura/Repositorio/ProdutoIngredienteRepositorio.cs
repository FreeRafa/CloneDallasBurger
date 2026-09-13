using CloneDallasBurger.Infraestrutura.Data;
using CloneDallasBurger.Modelo.Entidades;
using CloneDallasBurger.Modelo.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CloneDallasBurger.Infraestrutura.Repositorio
{
    public class ProdutoIngredienteRepositorio : IProdutoIngredienteRepositorio
    {
        private readonly CloneDallasBurgerContext _context;

        public ProdutoIngredienteRepositorio(CloneDallasBurgerContext context)
        {
            _context = context;
        }

        public async Task<ProdutoIngrediente?> ObterProdutoIngredienteAsync(int produtoId, int ingredienteId)
        {
            return await _context.ProdutosIngredientes.FindAsync(produtoId, ingredienteId);
        }

        public async Task<ProdutoIngrediente> CriarProdutoIngredienteAsync(ProdutoIngrediente produtoIngrediente)
        {
            _context.ProdutosIngredientes.Add(produtoIngrediente);
            await _context.SaveChangesAsync();
            return produtoIngrediente;
        }

        public async Task<List<ProdutoIngrediente>> ObterTodosProdutosIngredientesAsync()
        {
            return await _context.ProdutosIngredientes.ToListAsync();
        }

        public async Task<ProdutoIngrediente> AtualizarProdutoIngredienteAsync(ProdutoIngrediente produtoIngrediente)
        {
            _context.ProdutosIngredientes.Update(produtoIngrediente);
            await _context.SaveChangesAsync();
            return produtoIngrediente;
        }

        public async Task<ProdutoIngrediente?> DeletarProdutoIngredienteAsync(int produtoId, int ingredienteId)
        {
            var produtoIngrediente = await _context.ProdutosIngredientes.FindAsync(produtoId, ingredienteId);
            if (produtoIngrediente != null)
            {
                _context.ProdutosIngredientes.Remove(produtoIngrediente);
                await _context.SaveChangesAsync();
            }
            return produtoIngrediente;
        }

        
    }
}
