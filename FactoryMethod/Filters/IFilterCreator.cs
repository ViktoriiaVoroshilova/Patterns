namespace FactoryMethod.Filters
{
    internal interface IFilterCreator
    {
        IFilter? Create(Bank bank, Country country);
    }
}
