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

        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Pedido> Pedido { get; set; }
        public DbSet<Mesa> Mesa { get; set; }
        public DbSet<ItemPedido> ItemPedido { get; set; }
        public DbSet<ItemPedidoPersonalizacao> ItemPedidoPersonalizacao { get; set; }
        public DbSet<ProdutoIngrediente> ProdutoIngrediente { get; set; }
        public DbSet<Ingrediente> Ingrediente { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Categoria> Categoria { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            modelBuilder.Entity<ProdutoIngrediente>()
                .HasKey(pi => new { pi.ProdutoId, pi.IngredienteId });
        }
    }
}
