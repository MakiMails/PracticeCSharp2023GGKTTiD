
using System.Diagnostics;

int resultThread1 = 0;
Stopwatch sWatch = new Stopwatch();
sWatch.Start();
Thread thread1 = new Thread(() => { resultThread1 = Sum(); });
int resultThread2 = 0;
Thread thread2 = new Thread(() => { resultThread2 = Sum(); });
thread1.Start();
thread2.Start();
thread1.Join();
thread2.Join();
sWatch.Stop();
Console.WriteLine($"Количество затрачиного времени(миллисекунд): {sWatch.ElapsedMilliseconds}");
Console.WriteLine($"Результат выполнения первого потока: {resultThread1}");
Console.WriteLine($"Результат выполнения второго потока: {resultThread2}");


int Sum()
{
    int sum = 0;
    for (int i = 1; i <= 10; i++)
    {
        sum += i;
    }

    return sum;
}