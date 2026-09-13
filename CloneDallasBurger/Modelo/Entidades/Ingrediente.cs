using System;
using System.Collections.Generic;
using System.Text;

namespace CloneDallasBurger.Modelo.Entidades
{
    public class Ingrediente
    {
        public int IngredienteId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Tipo { get; set; } = string.Empty;
        public decimal PrecoAdicional { get; set; }
        public bool Vegano { get; set; }
        public bool DisponivelComoExtra { get; set; }
    }
}
