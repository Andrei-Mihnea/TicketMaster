
namespace Models
{
    public class EvenimentModel
    {
        private int id { get; set; }
        private int idOwner{ get; set; }
        public string? nume { get; set; }
        public string? locatie { get; set; }
        public string? descriere { get; set; }
        public int numarLocuri{ get; set;}  

    }
}