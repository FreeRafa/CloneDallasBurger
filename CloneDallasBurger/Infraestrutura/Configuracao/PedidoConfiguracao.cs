using CloneDallasBurger.Modelo.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloneDallasBurger.Infraestrutura.Configuracao
{
    public class PedidoConfiguracao : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder) 
        {
            builder.ToTable("Pedido");

            builder.HasKey(p => p.PedidoId);

            builder.Property(p => p.NumeroPessoas)
                .IsRequired();

            builder.Property(p => p.Status)
                .HasConversion<string>()
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(p => p.DataAbertura)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(p => p.DataFechamento)
                .HasColumnType("datetime")
                .IsRequired();

            builder.Property(p => p.FormaPagamento)
                .IsRequired();

            builder.Property(p => p.ValorTotal)
                .HasPrecision(8, 2)
                .IsRequired();

            builder.Property(p => p.ValorPorPessoa)
                .HasPrecision(8, 2)
                .IsRequired();

            builder.Property(p => p.Observacao)
                .IsRequired();

            builder.HasOne(p => p.Mesa)
                .WithMany()
                .HasForeignKey(p => p.MesaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Funcionario)
                .WithMany()
                .HasForeignKey(p => p.FuncionarioId)
                .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
