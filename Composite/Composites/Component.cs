namespace Composite.Composites;

public abstract class Component
{
    public abstract string ConvertToString();

    public virtual void AddComponent(Component component)
    {
        throw new NotImplementedException();
    }
}