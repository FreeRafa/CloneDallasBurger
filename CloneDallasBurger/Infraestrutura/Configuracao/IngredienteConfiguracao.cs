using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CloneDallasBurger.Modelo.Entidades;

namespace CloneDallasBurger.Infraestrutura.Configuracao
{
    public class IngredienteConfiguracao : IEntityTypeConfiguration<Ingrediente>
    {
        public void Configure(EntityTypeBuilder<Ingrediente> builder)
        {
            builder.ToTable("Ingrediente")
                .HasKey(i => i.IngredienteId);

            builder.Property(i => i.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(i => i.Tipo)
                .HasColumnName("Tipo")
                .HasMaxLength(30)
                .IsRequired();

            builder.Property(i => i.PrecoAdicional)
                .HasPrecision(6, 2)
                .IsRequired();

            builder.Property(i => i.Vegano)
                .HasColumnType("bit")
                .IsRequired();

            builder.Property(i => i.DisponivelComoExtra)
                .HasColumnType("bit")
                .IsRequired();
        }
    }
}
