using System;
using System.Collections.Generic;
using System.Text;

namespace CloneDallasBurger.Modelo.Entidades
{
    public class Funcionarios
    {
        public int FuncionarioId { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Cargo { get; set; } = string.Empty;
        public string Usuario { get; set; } = string.Empty;
        public string SenhaHash { get; set; } = string.Empty;
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }

    }
}
