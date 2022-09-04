namespace FactoryMethod.Filters
{
    internal class BarclaysFilterCreator : IBarclaysFilterCreator
    {
        public IFilter? Create(Country country)
        {
            return country switch
            {
                Country.England => new BarclaysEnglandFilter(),
                Country.USA => new BarclaysUsaFilter(),
                _ => null,
            };
        }
    }
}
