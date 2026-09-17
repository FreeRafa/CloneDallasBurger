using CloneDallasBurger.Modelo.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloneDallasBurger.Infraestrutura.Configuracao
{
    public class ItemPedidoPersonalizacaoConfiguracao : IEntityTypeConfiguration<ItemPedidoPersonalizacao>
    {
        public void Configure(EntityTypeBuilder<ItemPedidoPersonalizacao> builder) 
        {
            builder.ToTable("ItemPedidoPersonalizacao");

            builder.HasKey(ipp => ipp.PersonalizacaoId);

            builder.Property(ipp => ipp.Acao)
                .IsRequired();

            builder.Property(ipp => ipp.PrecoAdicional)
                .HasPrecision(6, 2)
                .IsRequired();

            builder.HasOne(ipp => ipp.ItemPedido)
                .WithMany()
                .HasForeignKey(ipp => ipp.ItemPedidoId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(ipp => ipp.Ingrediente)
                .WithMany()
                .HasForeignKey(ipp => ipp.IngredienteId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
