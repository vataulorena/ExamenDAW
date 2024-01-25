using ExamenDAW.Data;
using ExamenDAW.Models.Produs;
using ExamenDAW.Repositories.GenericRepository;

namespace ExamenDAW.Repositories.ProdusRepo
{
    public class ProdusRepository: GenericRepository<Produs>, IProdusRepository
    {
        public ProdusRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
