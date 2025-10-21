namespace Models
{
    public class BiletPacheteEvenimenteModel
    {
        public string? id { get; private set; }
        public int pachetId { get; private set; }
        public int evenimentId { get; set; }
    }
}