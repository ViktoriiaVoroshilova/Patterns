namespace SingletonPattern;

internal class SimpleSingleton
{
    public string Date { get; private set; }

    private SimpleSingleton() => Date = DateTime.Now.TimeOfDay.ToString();

    public static SimpleSingleton Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new SimpleSingleton();
            }

            return _instance;
        }
    }

    private static SimpleSingleton? _instance;
}
