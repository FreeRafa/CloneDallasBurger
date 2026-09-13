using System;
using System.Collections.Generic;
using System.Text;

namespace CloneDallasBurger.Modelo.Entidades
{
    public class Itens_Pedidos_Personalizacao
    {
        public int ItemPedidoPersonalizacaoId { get; set; }
        public string Acao { get; set; } = string.Empty;
        public decimal PrecoAdicional { get; set; }



        public int ItemPedidoId { get; set; }
        public Itens_Pedidos? Itens_Pedido { get; set; }

        public int IngredienteId { get; set; }
        public Ingredientes? Ingredientes { get; set; }
    }
}
