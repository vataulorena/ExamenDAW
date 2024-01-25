using ExamenDAW.Models.Comanda;

namespace ExamenDAW.Services.ComandaServ
{
    public interface IComandaService
    {
        Task<IEnumerable<Comanda>> GetAllComenzi();
    }
}
