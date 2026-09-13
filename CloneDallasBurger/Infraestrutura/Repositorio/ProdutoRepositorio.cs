using CloneDallasBurger.Infraestrutura.Data;
using CloneDallasBurger.Modelo.Entidades;
using CloneDallasBurger.Modelo.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CloneDallasBurger.Infraestrutura.Repositorio
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly CloneDallasBurgerContext _context;

        public ProdutoRepositorio(CloneDallasBurgerContext context)
        {
            _context = context;
        }

        public async Task<Produto?> ObterProdutoPorIdAsync(int Id)
        {
            return await _context.Produtos.FindAsync(Id);
        }

        public async Task<Produto> CriarProdutoAsync(Produto produto)
        {
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();
            return produto;
        }

        public async Task<List<Produto>> ObterTodosProdutosAsync()
        {
            return await _context.Produtos.ToListAsync();
        }

        public async Task<Produto> AtualizarProdutoAsync(Produto produto)
        {
            _context.Produtos.Update(produto);
            await _context.SaveChangesAsync();
            return produto;
        }

        public async Task<Produto?> DeletarProdutoAsync(int Id)
        {
            var produto = await _context.Produtos.FindAsync(Id);
            if (produto != null)
            {
                _context.Produtos.Remove(produto);
                await _context.SaveChangesAsync();
            }
            return produto;
        }
    }
}
