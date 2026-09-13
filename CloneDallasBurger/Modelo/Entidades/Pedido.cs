using CloneDallasBurger.Modelo.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloneDallasBurger.Modelo.Entidades
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public int NumeroPessoas { get; set; }
        public PedidoStatus Status { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime? DataFechamento { get; set; } 
        public string FormaPagamento { get; set; } = string.Empty;
        public decimal ValorTotal { get; set; }
        public decimal ValorPorPessoa { get; set; }
        public string Observacao { get; set; } = string.Empty;


        public int MesaId { get; set; }
        public Mesa? Mesa { get; set; } 

        public int FuncionarioId { get; set; }
        public Funcionario? Funcionario { get; set; }
    }
}
