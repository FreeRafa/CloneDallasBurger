using System;
using System.Collections.Generic;
using System.Text;
using CloneDallasBurger.Modelo.Entidades;
using System.Threading.Tasks;

namespace CloneDallasBurger.Modelo.Interfaces
{
    public interface IIngredienteRepositorio
    {
        public Task<Ingrediente?> ObterIngredientePorIdAsync(int Id);
        public Task<Ingrediente> CriarIngredienteAsync(Ingrediente ingrediente);
        public Task<List<Ingrediente>> ObterTodosIngredientesAsync();
        public Task<Ingrediente> AtualizarIngredienteAsync(Ingrediente ingrediente);
        public Task<Ingrediente?> DeletarIngredienteAsync(int Id);
    }
}
