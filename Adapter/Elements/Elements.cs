using Adapter.Elements;
using AutoFixture;

internal class Elements<T> : IElements<T>
{
    public Elements()
    {
        elements = _fixture.CreateMany<T>();
    }

    public IEnumerable<T> GetElements() => elements;

    private readonly IEnumerable<T> elements;
    private readonly Fixture _fixture = new();
}