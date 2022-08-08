namespace Adapter.Elements
{
    public interface IElements<T>
    {
        IEnumerable<T> GetElements();
    }
}
