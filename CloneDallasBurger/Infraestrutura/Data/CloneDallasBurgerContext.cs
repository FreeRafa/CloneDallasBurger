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

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<ItemPedidoPersonalizacao> ItensPedidosPersonalizacao { get; set; }
        public DbSet<ProdutoIngrediente> ProdutosIngredientes { get; set; }
        public DbSet<Ingrediente> Ingredientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            
            modelBuilder.Entity<ProdutoIngrediente>()
                .HasKey(pi => new { pi.ProdutoId, pi.IngredienteId });
        }
    }
}
