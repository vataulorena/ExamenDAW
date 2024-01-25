using ExamenDAW.Models.Base;
using ExamenDAW.Models;

namespace ExamenDAW.Models.ComandaProdus
{
    public class ComandaProdus : BaseEntity
    {
        public int ComandaId { get; set; }
        public int ProdusId { get; set; }
        public Produs.Produs Produs { get; set; }
        public Comanda.Comanda Comanda { get; set; }



    }
}
