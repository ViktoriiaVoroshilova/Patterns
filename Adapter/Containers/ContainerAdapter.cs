using Adapter.Elements;

namespace Adapter.Containers
{
    internal class ContainerAdapter<T> : IContainer<T>
    {
        public ContainerAdapter(IElements<T> adaptee)
        {
            _elements = adaptee.GetElements();
        }

        public IEnumerable<T> Items => _elements;

        public int Count => _elements.Count();

        private readonly IEnumerable<T> _elements;
    }
}
