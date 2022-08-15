namespace AbstractFactory.Filters
{
    internal interface IBarclaysFilterCreator
    {
        IFilter? Create(Country country);
    }
}
