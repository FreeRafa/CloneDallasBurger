using System;
using System.Collections.Generic;
using System.Text;
using CloneDallasBurger.Modelo.Entidades;
using System.Threading.Tasks;

namespace CloneDallasBurger.Modelo.Interfaces
{
    public interface IPedidoRepositorio
    {
        public Task<Pedido?> ObterPedidoPorIdAsync(int Id);
        public Task<Pedido> CriarPedidoAsync(Pedido pedido);
        public Task<List<Pedido>> ObterTodosPedidosAsync();
        public Task<Pedido> AtualizarPedidoAsync(Pedido pedido);
        public Task<Pedido?> DeletarPedidoAsync(int Id);
    }
}
