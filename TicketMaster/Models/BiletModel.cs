namespace Models
{
    public class BiletModel//1 relationship to pachet-event dto
    {
        public string? id { get; private set; }
        public int pachetId { get; private set; }
        public int evenimentId { get; set; }
    }
}