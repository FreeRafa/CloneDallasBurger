using System;
using System.Collections.Generic;
using System.Text;
using CloneDallasBurger.Modelo.Entidades;
using System.Threading.Tasks;

namespace CloneDallasBurger.Modelo.Interfaces
{
    public interface IItemPedidoPersonalizacaoRepositorio
    {
        public Task<ItemPedidoPersonalizacao> ObterItemPedidoPersonalizacaoPorIdAsync(int Id);
        public Task<ItemPedidoPersonalizacao> CriarItemPedidoPersonalizacaoAsync(ItemPedidoPersonalizacao itemPedidoPersonalizacao);
        public Task<List<ItemPedidoPersonalizacao>> ObterTodosItensPedidoPersonalizacaoAsync();
        public Task<ItemPedidoPersonalizacao> AtualizarItemPedidoPersonalizacaoAsync(ItemPedidoPersonalizacao itemPedidoPersonalizacao);
        public Task<ItemPedidoPersonalizacao> DeletarItemPedidoPersonalizacaoAsync(int Id);
    }
}
