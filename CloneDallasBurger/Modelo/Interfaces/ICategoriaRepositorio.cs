using System;
using System.Collections.Generic;
using System.Text;
using CloneDallasBurger.Modelo.Entidades;
using System.Threading.Tasks;

namespace CloneDallasBurger.Modelo.Interfaces
{
    public interface ICategoriaRepositorio
    {
        public Task<Categoria?> ObterCategoriaPorIdAsync(int Id);
        public Task<Categoria> CriarCategoriaAsync(Categoria categoria);
        public Task<List<Categoria>> ObterTodasCategoriasAsync();
        public Task<Categoria> AtualizarCategoriaAsync(Categoria categoria);
        public Task<Categoria?> DeletarCategoriaAsync(int Id);
    }
}
