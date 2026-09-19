using CloneDallasBurger.Modelo.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CloneDallasBurger.Infraestrutura.Data.Configuracoes
{
    public class ProdutoIngredienteConfiguracao : IEntityTypeConfiguration<ProdutoIngrediente>
    {
        public void Configure(EntityTypeBuilder<ProdutoIngrediente> builder)
        {
            builder.ToTable("ProdutoIngrediente");

            // Chave composta
            builder.HasKey(pi => new { pi.ProdutoId, pi.IngredienteId });

            // Relacionamento com Produto
            builder.HasOne(pi => pi.Produto)
                   .WithMany() // ou .WithMany(p => p.ProdutoIngredientes) se adicionares a coleção em Produto
                   .HasForeignKey(pi => pi.ProdutoId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Relacionamento com Ingrediente
            builder.HasOne(pi => pi.Ingrediente)
                   .WithMany()
                   .HasForeignKey(pi => pi.IngredienteId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.Property(pi => pi.Removivel)
                   .HasDefaultValue(true);
        }
    }
}