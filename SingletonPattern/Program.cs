using SingletonPattern;


(new Thread(() => Console.WriteLine(SimpleSingleton.Instance.Date))).Start();
(new Thread(() => Console.WriteLine(SimpleSingleton.Instance.Date))).Start();
(new Thread(() => Console.WriteLine(SimpleSingleton.Instance.Date))).Start();
(new Thread(() => Console.WriteLine(SimpleSingleton.Instance.Date))).Start();
(new Thread(() => Console.WriteLine(SimpleSingleton.Instance.Date))).Start();
Console.WriteLine(SimpleSingleton.Instance.Date);


(new Thread(() => Console.WriteLine(LockSingleton.Instance.Date))).Start();
(new Thread(() => Console.WriteLine(LockSingleton.Instance.Date))).Start();
(new Thread(() => Console.WriteLine(LockSingleton.Instance.Date))).Start();
(new Thread(() => Console.WriteLine(LockSingleton.Instance.Date))).Start();
(new Thread(() => Console.WriteLine(LockSingleton.Instance.Date))).Start();
Console.WriteLine(LockSingleton.Instance.Date);


(new Thread(() => Console.WriteLine(SafeSingleton.Instance.Date))).Start();
(new Thread(() => Console.WriteLine(SafeSingleton.Instance.Date))).Start();
(new Thread(() => Console.WriteLine(SafeSingleton.Instance.Date))).Start();
(new Thread(() => Console.WriteLine(SafeSingleton.Instance.Date))).Start();
(new Thread(() => Console.WriteLine(SafeSingleton.Instance.Date))).Start();
Console.WriteLine(SafeSingleton.Instance.Date);

Console.ReadLine();
