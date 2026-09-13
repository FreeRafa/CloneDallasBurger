using System;
using System.Collections.Generic;
using System.Text;
using CloneDallasBurger.Modelo.Entidades;
using System.Threading.Tasks;
using CloneDallasBurger.Modelo.Enums;

namespace CloneDallasBurger.Modelo.Interfaces
{
    public interface IMesaRepositorio
    {
        public Task<Mesa> ObterMesaPorIdAsync(int Id);
        public Task<Mesa> CriarMesaAsync(Mesa mesa);
        public Task<List<Mesa>> ObterTodasMesasAsync();
        public Task<Mesa> AtualizarMesaAsync(Mesa mesa);
        public Task<Mesa> DeletarMesaAsync(int Id);

        //Listar Mesas livres, ocupadas, reservadas ou em manutenção
        public Task<List<Mesa>> ObterMesasPorStatusAsync(MesaStatus mesaStatus);
    }
}
