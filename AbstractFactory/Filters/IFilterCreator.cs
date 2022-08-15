namespace AbstractFactory.Filters
{
    public interface IFilterCreator
    {
        IFilter? Create(Bank bank, Country country);
    }
}
