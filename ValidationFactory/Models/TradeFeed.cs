namespace ValidationFactory.Models
{
    public class TradeFeed
    {
        public int StagingId { get; set; }

        public int CounterpartyId { get; set; }

        public int PrincipalId { get; set; }

        public int SourceAccountId { get; set; }

        public string SourceTradeRef { get; set; } = null!;

        public DateTimeOffset ValuationDate { get; set; }

        public decimal CurrentPrice { get; set; }
    }
}
