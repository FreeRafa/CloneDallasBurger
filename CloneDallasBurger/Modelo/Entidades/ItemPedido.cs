using CloneDallasBurger.Modelo.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloneDallasBurger.Modelo.Entidades
{
    public class ItemPedido
    {
        public int ItemPedidoId { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public string Observacao { get; set; } = string.Empty;
        public ItemPedidoStatus Status { get; set; }


        public int PedidoId { get; set; }
        public Pedido? Pedido { get; set; }
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }
    }
}
