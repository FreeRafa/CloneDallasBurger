using CloneDallasBurger.Modelo.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace CloneDallasBurger.Infraestrutura.Configuracao
{
    public class FuncionarioConfiguracao : IEntityTypeConfiguration<Funcionario> 
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder) 
        {
            builder.ToTable("Funcionario");
            builder.HasKey(f => f.FuncionarioId);

            builder.Property(f => f.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(f => f.Cargo)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(f => f.Usuario)
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(f => f.SenhaHash)
                .IsRequired()
                .HasMaxLength(255);
                
            builder.Property(f => f.Ativo)
                .HasColumnType("bit");


            builder.Property(f => f.DataCadastro)
                .HasColumnType("datetime")
                .IsRequired();
        }
    }
}
