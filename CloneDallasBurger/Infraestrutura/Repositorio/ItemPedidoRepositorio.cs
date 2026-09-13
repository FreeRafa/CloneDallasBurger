using CloneDallasBurger.Infraestrutura.Data;
using CloneDallasBurger.Modelo.Entidades;
using CloneDallasBurger.Modelo.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CloneDallasBurger.Infraestrutura.Repositorio
{
    public class ItemPedidoRepositorio : IItemPedidoRepositorio
    {
        private readonly CloneDallasBurgerContext _context;

        public ItemPedidoRepositorio(CloneDallasBurgerContext context)
        {
            _context = context;
        }

        public async Task<ItemPedido?> ObterItemPedidoPorIdAsync(int Id)
        {
            return await _context.ItensPedidos.FindAsync(Id);
        }

        public async Task<ItemPedido> CriarItemPedidoAsync(ItemPedido itemPedido)
        {
            _context.ItensPedidos.Add(itemPedido);
            await _context.SaveChangesAsync();
            return itemPedido;
        }

        public async Task<List<ItemPedido>> ObterTodosItensPedidoAsync()
        {
            return await _context.ItensPedidos.ToListAsync();
        }

        public async Task<ItemPedido> AtualizarItemPedidoAsync(ItemPedido itemPedido)
        {
            _context.ItensPedidos.Update(itemPedido);
            await _context.SaveChangesAsync();
            return itemPedido;
        }

        public async Task<ItemPedido?> DeletarItemPedidoAsync(int Id)
        {
            var itemPedido = await _context.ItensPedidos.FindAsync(Id);
            if (itemPedido != null)
            {
                _context.ItensPedidos.Remove(itemPedido);
                await _context.SaveChangesAsync();
            }
            return itemPedido;
        }
    }
}
