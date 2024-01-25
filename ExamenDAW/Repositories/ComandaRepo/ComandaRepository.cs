using ExamenDAW.Data;
using ExamenDAW.Models.Comanda;
using ExamenDAW.Repositories.GenericRepository;

namespace ExamenDAW.Repositories.ComandaRepo
{
    public class ComandaRepository: GenericRepository<Comanda>, IComandaRepository
    {
        public ComandaRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
