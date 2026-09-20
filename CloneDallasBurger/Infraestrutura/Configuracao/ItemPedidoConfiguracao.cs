using CloneDallasBurger.Modelo.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloneDallasBurger.Infraestrutura.Configuracao
{
    public class ItemPedidoConfiguracao : IEntityTypeConfiguration<ItemPedido> 
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder) 
        {
            builder.ToTable("ItemPedido");

            builder.HasKey(i => i.ItemPedidoId);

            builder.Property(i => i.Quantidade)
                .IsRequired();

            builder.Property(i => i.PrecoUnitario)
                .HasPrecision(6, 2)
                .IsRequired();

            builder.Property(i => i.Observacao)
                .HasMaxLength(300)
                .IsRequired(false);

            builder.Property(i => i.Status)
                .HasConversion<string>()
                .HasMaxLength(20)
                .IsRequired();

            builder.HasOne(i => i.Pedido)
                 .WithMany()
                 .HasForeignKey(i => i.PedidoId)
                 .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(i => i.Produto)
                .WithMany()
                .HasForeignKey(i => i.ProdutoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
