using System;
using System.Collections.Generic;
using System.Text;
using CloneDallasBurger.Modelo.Entidades;
using System.Threading.Tasks;

namespace CloneDallasBurger.Modelo.Interfaces
{
    public interface IItemPedidoRepositorio
    {
        public Task<ItemPedido> ObterItemPedidoPorIdAsync(int Id);
        public Task<ItemPedido> CriarItemPedidoAsync(ItemPedido itemPedido);
        public Task<List<ItemPedido>> ObterTodosItensPedidoAsync();
        public Task<ItemPedido> AtualizarItemPedidoAsync(ItemPedido itemPedido);
        public Task<ItemPedido> DeletarItemPedidoAsync(int Id);
    }
}
