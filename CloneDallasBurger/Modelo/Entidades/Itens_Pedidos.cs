using CloneDallasBurger.Modelo.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloneDallasBurger.Modelo.Entidades
{
    public class Itens_Pedidos
    {
        public int ItemPedidoId { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public string Observacao { get; set; } = string.Empty;
        public Itens_Pedidos_Status Status { get; set; }


        public int PedidoId { get; set; }
        public Pedidos? Pedidos { get; set; }
        public int ProdutoId { get; set; }
        public Produtos? Produtos { get; set; }
    }
}
