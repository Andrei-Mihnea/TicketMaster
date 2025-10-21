
namespace Models
{
    public class EvenimentModel//eveniment table dto
    {
        public int id { get; private set; }
        public int idOwner{ get; private set; }
        public string? nume { get; set; }
        public string? locatie { get; set; }
        public string? descriere { get; set; }
        public int numarLocuri{ get; set;}  

    }
}