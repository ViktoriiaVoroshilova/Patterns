namespace AbstractFactory.Filters
{
    public class BofaFilter : IFilter
    {
        public IEnumerable<Trade> Match(IEnumerable<Trade> trades)
        {
            return trades.Where(x => x.Amount > MinAmount);
        }

        private const int MinAmount = 70;
    }
}
