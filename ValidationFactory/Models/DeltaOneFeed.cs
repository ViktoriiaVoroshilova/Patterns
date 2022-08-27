namespace ValidationFactory.Models
{
    public class DeltaOneFeed : TradeFeed
    {
        public string Isin { get; set; } = null!;

        public DateTimeOffset MaturityDate { get; set; }
    }
}
