namespace AbstractFactory.Filters
{
    internal class FilterCreator : IFilterCreator
    {
        public IFilter? Create(Bank bank, Country country)
        {
            return bank switch
            {
                Bank.Bofa => new BofaFilter(),
                Bank.Connacord => new ConnacordFilter(),
                Bank.Barclays => new BarclaysFilter(country),
                Bank.Deutsche => new DeutscheFilter(),
                _ => null,
            };
        }
    }
}
