namespace AbstractFactory.Filters
{
    internal class DeutscheFilter : IFilter
    {
        public IEnumerable<Trade> Match(IEnumerable<Trade> trades)
        {
            return trades.Where(x => x.Type.Equals(Type, StringComparison.InvariantCultureIgnoreCase)
                && x.SubType.Equals(SubType, StringComparison.InvariantCultureIgnoreCase)
                && x.Amount > MinAmount
                && x.Amount < MaxAmount);
        }


        private const int MinAmount = 90;
        private const int MaxAmount = 120;
        private const string Type = "Option";
        private const string SubType = "NewOption";
    }
}
