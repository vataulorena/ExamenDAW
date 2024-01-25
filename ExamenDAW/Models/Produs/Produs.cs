using ExamenDAW.Models.Base;

namespace ExamenDAW.Models.Produs;

public class Produs : BaseEntity
{
    public int Id { get; set; }
    public string ProdusNume { get; set; }
    public long Pret { get; set; }

    public ICollection<ComandaProdus.ComandaProdus> ComandaProdus { get; set; }

}
