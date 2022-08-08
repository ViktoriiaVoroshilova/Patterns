using AutoFixture;

namespace Adapter.Elements;

internal class Elements<T> : IElements<T>
{
    public Elements()
    {
        _elements = _fixture.CreateMany<T>();
    }

    public IEnumerable<T> GetElements() => _elements;

    private readonly IEnumerable<T> _elements;
    private readonly Fixture _fixture = new();
}
