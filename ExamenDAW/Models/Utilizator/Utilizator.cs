using ExamenDAW.Models.Base;

namespace ExamenDAW.Models.Utilizator
{
    public class Utilizator : BaseEntity
    {
    
        public string Nume { get; set; }

        public ICollection<Comanda.Comanda> Comanda { get; set; }
    }
}
