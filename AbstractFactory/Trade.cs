namespace AbstractFactory
{
    public class Trade
    {
        public int Amount { get; set; }

        public string Type { get; set; } = null!;

        public string SubType { get; set; } = null!;

        public override string ToString()
        {
            return $"Amount: {Amount}, Type: {Type}, SubType: {SubType}";
        }
    }
}