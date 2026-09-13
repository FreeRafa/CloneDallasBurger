using CloneDallasBurger.Infraestrutura.Data;
using CloneDallasBurger.Modelo.Entidades;
using CloneDallasBurger.Modelo.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CloneDallasBurger.Infraestrutura.Repositorio
{
    public class ItemPedidoPersonalizacaoRepositorio : IItemPedidoPersonalizacaoRepositorio
    {
        private readonly CloneDallasBurgerContext _context;

        public ItemPedidoPersonalizacaoRepositorio(CloneDallasBurgerContext context)
        {
            _context = context;
        }

        public async Task<ItemPedidoPersonalizacao?> ObterItemPedidoPersonalizacaoPorIdAsync(int Id)
        {
            return await _context.ItensPedidosPersonalizacao.FindAsync(Id);
        }

        public async Task<ItemPedidoPersonalizacao> CriarItemPedidoPersonalizacaoAsync(ItemPedidoPersonalizacao itemPedidoPersonalizacao)
        {
            _context.ItensPedidosPersonalizacao.Add(itemPedidoPersonalizacao);
            await _context.SaveChangesAsync();
            return itemPedidoPersonalizacao;
        }

        public async Task<List<ItemPedidoPersonalizacao>> ObterTodosItensPedidoPersonalizacaoAsync()
        {
            return await _context.ItensPedidosPersonalizacao.ToListAsync();
        }

        public async Task<ItemPedidoPersonalizacao> AtualizarItemPedidoPersonalizacaoAsync(ItemPedidoPersonalizacao itemPedidoPersonalizacao)
        {
            _context.ItensPedidosPersonalizacao.Update(itemPedidoPersonalizacao);
            await _context.SaveChangesAsync();
            return itemPedidoPersonalizacao;
        }

        public async Task<ItemPedidoPersonalizacao?> DeletarItemPedidoPersonalizacaoAsync(int Id)
        {
            var itemPedidoPersonalizacao = await _context.ItensPedidosPersonalizacao.FindAsync(Id);
            if (itemPedidoPersonalizacao != null)
            {
                _context.ItensPedidosPersonalizacao.Remove(itemPedidoPersonalizacao);
                await _context.SaveChangesAsync();
            }
            return itemPedidoPersonalizacao;
        }

    }
}
