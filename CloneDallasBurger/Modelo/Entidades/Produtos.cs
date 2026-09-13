using System;
using System.Collections.Generic;
using System.Text;

namespace CloneDallasBurger.Modelo.Entidades
{
    public class Produtos
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public decimal Preco { get; set; }
        public bool Vegano { get; set; }
        public bool PermiteTrocaProteica { get; set; }
        public bool Disponivel { get; set; }

        public int CategoriaId { get; set; }
        public Categorias? Categorias { get; set; }
    }
}
