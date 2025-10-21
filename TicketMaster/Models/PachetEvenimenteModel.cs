
namespace Models
{
    public class PachetEvenimenteModel//2 relationship to event-pachet dto
    {
        public int pachetId { get; private set; }
        public int evenimentId { get; private set; }
        public int numarLocuri { get; set; }
    }
}