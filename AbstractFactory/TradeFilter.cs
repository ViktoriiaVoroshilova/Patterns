using AbstractFactory.Filters;

namespace AbstractFactory
{
    public class TradeFilter
    {
        public TradeFilter(IFilterCreator filterCreator)
        {
            _filterCreator = filterCreator;
        }

        public IEnumerable<Trade> FilterForBank(IEnumerable<Trade> trades, Bank bank, Country country)
        {
            var filter = _filterCreator.Create(bank, country);

            if (filter is null) return trades;

            return filter!.Match(trades);
        }

        private readonly IFilterCreator _filterCreator;
    }
}
