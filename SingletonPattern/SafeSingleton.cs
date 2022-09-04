namespace SingletonPattern
{
    public class SafeSingleton
    {
        private static readonly SafeSingleton instance = new();

        public string Date { get; private set; }

        private SafeSingleton()
        {
            Date = DateTime.Now.TimeOfDay.ToString();
        }

        public static SafeSingleton Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
