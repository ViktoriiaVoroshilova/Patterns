using Adapter.Containers;

namespace Adapter.Printers
{
    internal class Printer : IPrinter
    {
        public void Print<T>(IContainer<T> container)
        {
            foreach (var item in container.Items)
            {
                Console.WriteLine(item!.ToString());
            }
        }
    }
}