using ExamenDAW.Models.Base;

namespace ExamenDAW.Models.Comanda
{
    public class Comanda : BaseEntity
    {
        public int Id { get; set; }

        public Guid UtilizatorId { get; set; }

        public ICollection<ComandaProdus.ComandaProdus> ComandaProdus { get; set; }

        public Utilizator.Utilizator Utilizator { get; set; }


    }
}
