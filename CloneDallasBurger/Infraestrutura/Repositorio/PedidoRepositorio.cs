using CloneDallasBurger.Infraestrutura.Data;
using CloneDallasBurger.Modelo.Entidades;
using CloneDallasBurger.Modelo.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CloneDallasBurger.Infraestrutura.Repositorio
{
    public class PedidoRepositorio : IPedidoRepositorio
    {
        private readonly CloneDallasBurgerContext _context;
        public PedidoRepositorio(CloneDallasBurgerContext context)
        {
            _context = context;
        }
        public async Task<Pedido?> ObterPedidoPorIdAsync(int Id)
        {
            return await _context.Pedidos.FindAsync(Id);
        }
        public async Task<Pedido> CriarPedidoAsync(Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            await _context.SaveChangesAsync();
            return pedido;
        }
        public async Task<List<Pedido>> ObterTodosPedidosAsync()
        {
            return await _context.Pedidos.ToListAsync();
        }
        public async Task<Pedido> AtualizarPedidoAsync(Pedido pedido)
        {
            _context.Pedidos.Update(pedido);
            await _context.SaveChangesAsync();
            return pedido;
        }
        public async Task<Pedido?> DeletarPedidoAsync(int Id)
        {
            var pedido = await _context.Pedidos.FindAsync(Id);
            if (pedido != null)
            {
                _context.Pedidos.Remove(pedido);
                await _context.SaveChangesAsync();
            }
            return pedido;
        }
    }
}
