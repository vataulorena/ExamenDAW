using ExamenDAW.Models.ComandaProdus;
using ExamenDAW.Repositories.ComandaProdusRepo;

namespace ExamenDAW.Services.ComandaProdusServ
{
    public class ComandaProdusService: IComandaProdusService
    {
        private readonly IComandaProdusRepository _comandaprodusRepository;
        public async Task<IEnumerable<ComandaProdus>> GetAllComandaProdus()
        {
            return await _comandaprodusRepository.GetAllAsync();
        }


        public async Task CreateAllComandaProdus(IList<ComandaProdus> comandaprodus)
        {
            foreach (var comprodus in comandaprodus)
            {
                await _comandaprodusRepository.CreateAsync(comprodus);

            }
            await _comandaprodusRepository.SaveAsync();
        }


        public async Task CreateComandaProdus(ComandaProdus comandaprodus)
        {
            await _comandaprodusRepository.CreateAsync(comandaprodus);
            await _comandaprodusRepository.SaveAsync();
        }
    }
}
