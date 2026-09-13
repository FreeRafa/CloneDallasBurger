using System;
using System.Collections.Generic;
using System.Text;
using CloneDallasBurger.Modelo.Enums;

namespace CloneDallasBurger.Modelo.Entidades
{
    public class Mesas
    {
        public int MesaId { get; set; }
        public int Numero { get; set; }
        public int Capacidade { get; set; }
        public MesasStatus Status { get; set; }
        public bool Ativo { get; set; }
    }
}
