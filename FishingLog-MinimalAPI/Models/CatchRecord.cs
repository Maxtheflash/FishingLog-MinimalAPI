namespace FishingLogMinimalApi.Models
{
    public class CatchRecord
    {
        public int Id { get; set; }
        public string Species { get; set; } = string.Empty;
        public double LengthInInches { get; set; }
        public double WeightInPounds { get; set; }
        public string Location { get; set; } = string.Empty;
        public DateTime DateCaught { get; set; }
    }
}
