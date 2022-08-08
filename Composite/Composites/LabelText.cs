namespace Composite.Composites;

public class LabelText : Component
{
    public LabelText(string value)
    {
        _value = value;
    }

    public override string ConvertToString()
    {
        return string.Format(Resources.Texts.LabelText, _value);
    }

    private readonly string _value;
}