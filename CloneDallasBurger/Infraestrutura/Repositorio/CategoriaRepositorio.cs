using CloneDallasBurger.Infraestrutura.Data;
using CloneDallasBurger.Modelo.Entidades;
using CloneDallasBurger.Modelo.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CloneDallasBurger.Infraestrutura.Repositorio
{
    public class CategoriaRepositorio : ICategoriaRepositorio
    {
        private readonly CloneDallasBurgerContext _context;

        public CategoriaRepositorio(CloneDallasBurgerContext context)
        {
            _context = context;
        }

        public async Task<Categoria?> ObterCategoriaPorIdAsync(int Id)
        {
            return await _context.Categorias.FindAsync(Id);
        }

        public async Task<Categoria> CriarCategoriaAsync(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            await _context.SaveChangesAsync();
            return categoria;
        }

        public async Task<List<Categoria>> ObterTodasCategoriasAsync()
        {
            return await _context.Categorias.ToListAsync();
        }

        public async Task<Categoria> AtualizarCategoriaAsync(Categoria categoria)
        {
            _context.Categorias.Update(categoria);
            await _context.SaveChangesAsync();
            return categoria;
        }

        public async Task<Categoria?> DeletarCategoriaAsync(int id)
        {
            var categoria = await _context.Categorias.FindAsync(id);
            if (categoria != null)
            {
                _context.Categorias.Remove(categoria);
                await _context.SaveChangesAsync();
            }
            return categoria;
        }
    }
}
