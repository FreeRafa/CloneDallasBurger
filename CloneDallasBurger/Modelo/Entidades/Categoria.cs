using System;
using System.Collections.Generic;
using System.Text;

namespace CloneDallasBurger.Modelo.Entidades
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int Ordem { get; set; } 
    }
}
