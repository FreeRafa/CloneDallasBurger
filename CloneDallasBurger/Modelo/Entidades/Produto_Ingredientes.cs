using System;
using System.Collections.Generic;
using System.Text;

namespace CloneDallasBurger.Modelo.Entidades
{
    public class Produto_Ingredientes
    {
        public int ProdutoId { get; set; }
        public int IngredienteId { get; set; }
        public bool Removivel { get; set; }
        
    }
}
