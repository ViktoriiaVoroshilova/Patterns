namespace Composite.Composites;

public class InputText : Component
{
    public InputText(string name, string value)
    {
        _name = name;
        _value = value;
    }

    public override string ConvertToString()
    {
        return string.Format(Resources.Texts.InputText, _name, _value);
    }

    private readonly string _name;
    private readonly string _value;
}