namespace FactoryMethod.Filters
{
    internal class FilterCreator : IFilterCreator
    {
        public FilterCreator(IBarclaysFilterCreator barclaysFilterCreator)
        {
            _barclaysFilterCreator = barclaysFilterCreator;
        }

        public IFilter? Create(Bank bank, Country country)
        {
            return bank switch
            {
                Bank.Bofa => new BofaFilter(),
                Bank.Connacord => new ConnacordFilter(),
                Bank.Barclays => _barclaysFilterCreator.Create(country),
                Bank.Deutsche => new DeutscheFilter(),
                _ => null,
            };
        }

        private readonly IBarclaysFilterCreator _barclaysFilterCreator;
    }
}
