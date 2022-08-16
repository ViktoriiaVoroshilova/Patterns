namespace FactoryMethod.Filters
{
    internal class BarclaysEnglandFilter : IFilter
    {
        public IEnumerable<Trade> Match(IEnumerable<Trade> trades)
        {
            return trades.Where(x => x.Type.Equals(Type, StringComparison.InvariantCultureIgnoreCase)
                && x.Amount > MinAmount);
        }

        private const int MinAmount = 100;
        private const string Type = "Future";
    }
}
