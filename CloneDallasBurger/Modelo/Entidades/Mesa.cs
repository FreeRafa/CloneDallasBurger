using System;
using System.Collections.Generic;
using System.Text;
using CloneDallasBurger.Modelo.Enums;

namespace CloneDallasBurger.Modelo.Entidades
{
    public class Mesa
    {
        public int MesaId { get; set; }
        public int Numero { get; set; }
        public int Capacidade { get; set; }
        public MesaStatus Status { get; set; }
        public bool Ativa { get; set; }
    }
}
