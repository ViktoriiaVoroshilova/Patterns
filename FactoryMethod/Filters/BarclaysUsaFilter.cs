namespace FactoryMethod.Filters
{
    internal class BarclaysUsaFilter : IFilter
    {
        public IEnumerable<Trade> Match(IEnumerable<Trade> trades)
        {
            return trades.Where(x => x.Type.Equals(Type, StringComparison.InvariantCultureIgnoreCase)
                && x.SubType.Equals(SubType, StringComparison.InvariantCultureIgnoreCase)
                && x.Amount > MinAmount);
        }

        private const int MinAmount = 50;
        private const string SubType = "MyOption";
        private const string Type = "Option";
    }
}
