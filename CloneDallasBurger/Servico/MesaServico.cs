using CloneDallasBurger.Modelo.Entidades;
using CloneDallasBurger.Modelo.Interfaces;

namespace CloneDallasBurger.Servico
{
    public class MesaServico
    {
        private readonly IMesaRepositorio _mesaRepositorio;

        public MesaServico(IMesaRepositorio mesaRepositorio)
        {
            _mesaRepositorio = mesaRepositorio;
        }

        public async Task<List<Mesa>> ObterTodasMesasAsync()
        {
            return await _mesaRepositorio.ObterTodasMesasAsync();
        }
    }
}