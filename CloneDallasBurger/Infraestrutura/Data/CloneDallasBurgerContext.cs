using System;
using System.Collections.Generic;
using System.Text;
using CloneDallasBurger.Modelo.Entidades;
using Microsoft.EntityFrameworkCore;


namespace CloneDallasBurger.Infraestrutura.Data
{
    public class CloneDallasBurgerContext : DbContext
    {
        public CloneDallasBurgerContext(DbContextOptions<CloneDallasBurgerContext> options) : base(options)
        {
        }

        public DbSet<Funcionarios> funcionarios { get; set; }
        public DbSet<Pedidos> pedidos { get; set; }
        public DbSet<Mesas> mesas { get; set; }
        public DbSet<Itens_Pedidos> itens_pedidos { get; set; }
        public DbSet<Itens_Pedidos_Personalizacao> itens_Pedidos_Personalizacaos { get; set; }
        public DbSet<Produto_Ingredientes> produto_Ingredientes { get; set; }
        public DbSet<Ingredientes> ingredientes { get; set; }
        public DbSet<Produtos> produtos { get; set; }
        public DbSet<Categorias> categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            modelBuilder.Entity<Produto_Ingredientes>()
                .HasKey(pi => new { pi.ProdutoId, pi.IngredienteId });
        }
    }
}
