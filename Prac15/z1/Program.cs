Thread thread1 = new Thread(() => WriteNumFromTo("Первый поток", 1, 9));
Thread thread2 = new Thread(() => WriteNumFromTo("Второй поток", 10, 19));
Thread thread3 = new Thread(() => WriteNumFromTo("Третий поток", 20, 29));

thread1.Priority = ThreadPriority.Highest;
thread2.Priority = ThreadPriority.BelowNormal;
thread3.Priority = ThreadPriority.Lowest;


thread1.Start();
Thread.Sleep(40);
thread2.Start();
thread3.Start();



static void WriteNumFromTo(string mes, int from, int to)
{
    for(int i = from; i <= to; i++)
    {
        Console.WriteLine($"{mes} - {i}");
    }
}