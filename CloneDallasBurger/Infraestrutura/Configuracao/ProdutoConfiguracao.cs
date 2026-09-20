using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CloneDallasBurger.Modelo.Entidades;

namespace CloneDallasBurger.Infraestrutura.Configuracao
{
    public class ProdutoConfiguracao : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder) 
        {
            builder.ToTable("Produto");
             

            builder.HasKey(p => p.ProdutoId);

            builder.Property(p => p.Nome)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(p => p.Descricao)
                .HasMaxLength(500)
                .IsRequired(false);

            builder.Property(p => p.Preco)
                .HasPrecision(6, 2)
                .IsRequired();

            builder.Property(p => p.Vegano)
                .IsRequired();

            builder.Property(p => p.PermiteTrocaProteina)
                .IsRequired();

            builder.Property(p => p.Disponivel)
                .IsRequired();

            builder.HasOne(p => p.Categoria)
                .WithMany()
                .HasForeignKey(p => p.CategoriaId)
                .OnDelete(DeleteBehavior.Restrict);
        }  
    }
}
