using ExamenDAW.Models.Comanda;
using ExamenDAW.Repositories.ComandaRepo;

namespace ExamenDAW.Services.ComandaServ
{
    public class ComandaService: IComandaService
    {
        private readonly IComandaRepository _comandaRepository;
        public async Task<IEnumerable<Comanda>> GetAllComenzi()
        {
            return await _comandaRepository.GetAllAsync();
        }
    }
}
