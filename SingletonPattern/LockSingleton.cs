namespace SingletonPattern;

internal class LockSingleton
{
    public string Date { get; private set; }

    private LockSingleton() => Date = DateTime.Now.TimeOfDay.ToString();

    public static LockSingleton Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_locker)
                {
                    if (_instance == null) _instance = new LockSingleton(); ;
                }
            }

            return _instance;
        }
    }

    private static LockSingleton? _instance;
    private static readonly object _locker = new();
}
