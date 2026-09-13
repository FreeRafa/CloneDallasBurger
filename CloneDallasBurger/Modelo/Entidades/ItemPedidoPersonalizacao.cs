using System;
using System.Collections.Generic;
using System.Text;

namespace CloneDallasBurger.Modelo.Entidades
{
    public class ItemPedidoPersonalizacao
    {
        public int PersonalizacaoId { get; set; }
        public string Acao { get; set; } = string.Empty;
        public decimal PrecoAdicional { get; set; }



        public int ItemPedidoId { get; set; }
        public ItemPedido? ItemPedido { get; set; }

        public int IngredienteId { get; set; }
        public Ingrediente? Ingrediente { get; set; }
    }
}
