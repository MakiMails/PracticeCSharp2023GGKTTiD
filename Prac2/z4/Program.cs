//Задание 4
using static System.Math;

Console.Write("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());

double y;
if (x > 1)
{
    y = Log(2 * x) + Sqrt(1 + x * x);

}
else
{
    y = 2 * Cos(x) + 3 * x * x;
}
Console.WriteLine($"y: {y:.###}");