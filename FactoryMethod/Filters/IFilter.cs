namespace FactoryMethod.Filters
{
    internal interface IFilter
    {
        IEnumerable<Trade> Match(IEnumerable<Trade> trades);
    }
}
