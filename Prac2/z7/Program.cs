//Задание 8

Console.Write("Введите число А: ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 0)
{
    double sum = 0;

    for (int i = 0; i < n + 1; i++)
    {
        sum += Math.Pow(a, i);
        Console.WriteLine(sum);
    }

    Console.WriteLine($"Полученная сумма: {sum}");
}
else
{
    Console.WriteLine("N равен 0 или же меньше 0");
}