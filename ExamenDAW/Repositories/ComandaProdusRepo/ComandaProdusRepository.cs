using ExamenDAW.Data;
using ExamenDAW.Models.ComandaProdus;
using ExamenDAW.Repositories.GenericRepository;

namespace ExamenDAW.Repositories.ComandaProdusRepo
{
    public class ComandaProdusRepository: GenericRepository<ComandaProdus>, IComandaProdusRepository
    {
        public ComandaProdusRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
