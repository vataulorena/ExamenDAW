using ExamenDAW.Models.ComandaProdus.Dto;

namespace ExamenDAW.Models.Comanda.Dto
{
    public class ComandaResponseDto
    {
        public int Id { get; set; }

        public ICollection<ComandaProdusResponseDto> ComandaProdus { get; set; }
    }
}
