using ExamenDAW.Models.ComandaProdus;

namespace ExamenDAW.Services.ComandaProdusServ
{
    public interface IComandaProdusService
    {
        Task<IEnumerable<ComandaProdus>> GetAllComandaProdus();

        Task CreateAllComandaProdus(IList<ComandaProdus> comprodus);

        Task CreateComandaProdus(ComandaProdus comandaprodus);
    }
}
