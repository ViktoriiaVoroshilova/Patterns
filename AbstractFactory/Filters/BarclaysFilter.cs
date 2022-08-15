namespace AbstractFactory.Filters
{
    public class BarclaysFilter : IFilter
    {
        public BarclaysFilter(Country country)
        {
            _country = country;
        }

        public IEnumerable<Trade> Match(IEnumerable<Trade> trades)
        {
            return trades.Where(x => x.Type.Equals(Type, StringComparison.InvariantCultureIgnoreCase)
                && x.SubType.Equals(SubType, StringComparison.InvariantCultureIgnoreCase)
                && x.Amount > MinAmount);
        }

        private const int MinAmount = 10;
        private const string SubType = "MyOption";
        private const string Type = "Option";
        private Country _country;
    }
}
