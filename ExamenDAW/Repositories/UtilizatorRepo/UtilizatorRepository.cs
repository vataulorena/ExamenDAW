using ExamenDAW.Data;
using ExamenDAW.Models.Utilizator;
using ExamenDAW.Repositories.GenericRepository;

namespace ExamenDAW.Repositories.UtilizatorRepo
{
    public class UtilizatorRepository: GenericRepository<Utilizator>, IUtilizatorRepository
    {
        public UtilizatorRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
