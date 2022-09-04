namespace FactoryMethod.Filters
{
    internal class ConnacordFilter : IFilter
    {
        public IEnumerable<Trade> Match(IEnumerable<Trade> trades)
        {
            return trades.Where(x => x.Type.Equals(Type, StringComparison.InvariantCultureIgnoreCase)
                && x.Amount > MinAmount
                && x.Amount < MaxAmount);
        }

        private const int MinAmount = 10;
        private const int MaxAmount = 40;
        private const string Type = "Future";
    }
}
