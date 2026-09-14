using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CloneDallasBurger.Modelo.Entidades;

namespace CloneDallasBurger.Infraestrutura.Configuracao
{
    public class CategoriaConfiguracao : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder) 
        {
            builder.ToTable("Categoria");
            builder.HasKey(c => c.CategoriaId);

            builder.Property(c => c.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(50)
                .IsRequired();

            builder.HasIndex(c => c.Nome)
                .IsUnique();

            builder.Property(c => c.Ordem)
                .HasDefaultValue(0);
        }
    }
}


