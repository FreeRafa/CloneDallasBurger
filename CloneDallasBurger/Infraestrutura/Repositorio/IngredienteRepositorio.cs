using CloneDallasBurger.Infraestrutura.Data;
using CloneDallasBurger.Modelo.Entidades;
using CloneDallasBurger.Modelo.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CloneDallasBurger.Infraestrutura.Repositorio
{
    public class IngredienteRepositorio : IIngredienteRepositorio
    {
        private readonly CloneDallasBurgerContext _context;

        public IngredienteRepositorio(CloneDallasBurgerContext context)
        {
            _context = context;
        }

        public async Task<Ingrediente?> ObterIngredientePorIdAsync(int Id)
        {
            return await _context.Ingredientes.FindAsync(Id);
        }

        public async Task<Ingrediente> CriarIngredienteAsync(Ingrediente ingrediente)
        {
            _context.Ingredientes.Add(ingrediente);
            await _context.SaveChangesAsync();
            return ingrediente;
        }

        public async Task<List<Ingrediente>> ObterTodosIngredientesAsync()
        {
            return await _context.Ingredientes.ToListAsync();
        }

        public async Task<Ingrediente> AtualizarIngredienteAsync(Ingrediente ingrediente)
        {
            _context.Ingredientes.Update(ingrediente);
            await _context.SaveChangesAsync();
            return ingrediente;
        }

        public async Task<Ingrediente?> DeletarIngredienteAsync(int Id)
        {
            var ingrediente = await _context.Ingredientes.FindAsync(Id);
            if (ingrediente != null)
            {
                _context.Ingredientes.Remove(ingrediente);
                await _context.SaveChangesAsync();
            }
            return ingrediente;
        }
    }
}
