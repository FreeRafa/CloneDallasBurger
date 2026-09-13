using CloneDallasBurger.Infraestrutura.Data;
using CloneDallasBurger.Modelo.Entidades;
using CloneDallasBurger.Modelo.Enums;
using CloneDallasBurger.Modelo.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CloneDallasBurger.Infraestrutura.Repositorio
{
    public class MesaRepositorio : IMesaRepositorio
    {
        private readonly CloneDallasBurgerContext _context;

        public MesaRepositorio(CloneDallasBurgerContext context)
        {
            _context = context;
        }

        public async Task<Mesa?> ObterMesaPorIdAsync(int Id)
        {
            return await _context.Mesas.FindAsync(Id);
        }

        public async Task<Mesa> CriarMesaAsync(Mesa mesa)
        {
            _context.Mesas.Add(mesa);
            await _context.SaveChangesAsync();
            return mesa;
        }

        public async Task<List<Mesa>> ObterTodasMesasAsync()
        {
            return await _context.Mesas.ToListAsync();
        }

        public async Task<Mesa> AtualizarMesaAsync(Mesa mesa)
        {
            _context.Mesas.Update(mesa);
            await _context.SaveChangesAsync();
            return mesa;
        }

        public async Task<Mesa?> DeletarMesaAsync(int Id)
        {
            var mesa = await _context.Mesas.FindAsync(Id);
            if (mesa != null)
            {
                _context.Mesas.Remove(mesa);
                await _context.SaveChangesAsync();
            }
            return mesa;
        }

        public async Task<List<Mesa>> ObterMesasPorStatusAsync(MesaStatus mesaStatus)
        {
            return await _context.Mesas.Where(m => m.Status == mesaStatus).ToListAsync();
        }
    }
}
