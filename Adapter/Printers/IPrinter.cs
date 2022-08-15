using Adapter.Containers;

namespace Adapter.Printers
{
    public interface IPrinter
    {
        public void Print<T>(IContainer<T> container);
    }
}
