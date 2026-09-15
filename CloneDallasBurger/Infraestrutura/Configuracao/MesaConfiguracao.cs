using CloneDallasBurger.Modelo.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloneDallasBurger.Infraestrutura.Configuracao
{
    public class MesaConfiguracao : IEntityTypeConfiguration<Mesa>
    {
        public void Configure(EntityTypeBuilder<Mesa> builder) 
        {
            builder.ToTable("Mesa");

            builder.HasKey(m => m.MesaId);

            builder.Property(m => m.Numero)
                .IsRequired();

            builder.HasIndex(m => m.Numero)
                .IsUnique();

            builder.Property(m => m.Capacidade)
                .HasDefaultValue(4)
                .IsRequired();

            builder.Property(m => m.Status)
                .HasConversion<string>()
                .HasMaxLength(20)
                .IsRequired();
                        
            builder.Property(m => m.Ativa)
                .HasColumnType("bit")
                .IsRequired();

        }
    }
}
