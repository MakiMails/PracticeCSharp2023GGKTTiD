Console.Write("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

Thread thread1 = new Thread(() => 
{
    Console.WriteLine($"Поток 1 - метод 1: {Metod1(numA, n)}");
    Console.WriteLine($"Поток 1 - метод 2: {Metod2(numA, n)}");
});

Thread thread2 = new Thread(() => 
{
    Console.WriteLine($"Поток 2 - метод 1: {Metod1(numA, n)}");
});

thread1.Start();
thread2.Start();

double Metod1(int num,int n)
{
    double result = 0;
    for (int i = 1; i <= n; i++ )
    {
        result += Math.Pow(num, i);
    }
    return result;
}

int Metod2(int num, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= Convert.ToInt32(Math.Pow(num, i));
    }
    return result;
}