using System.Text;

namespace Composite.Composites;

public class Form : Component
{
    public Form(string name)
    {
        _name = name;
    }

    public override void AddComponent(Component component)
    {
        _childComponents.Add(component);
    }

    public override string ConvertToString()
    {
        var children = new StringBuilder("\n");

        foreach (var c in _childComponents)
        {
            children.Append($"{c.ConvertToString()}\n");
        }

        return string.Format(Resources.Texts.FormText, _name, children.ToString());
    }

    private readonly string _name;
    private readonly IList<Component> _childComponents = new List<Component>();
}