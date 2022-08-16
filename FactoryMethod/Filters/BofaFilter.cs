namespace FactoryMethod.Filters
{
    internal class BofaFilter : IFilter
    {
        public IEnumerable<Trade> Match(IEnumerable<Trade> trades)
        {
            return trades.Where(x => x.Amount > MinAmount);
        }

        private const int MinAmount = 70;
    }
}
