using static System.Math;

Console.Write("Введите a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b: ");
double b = Convert.ToDouble(Console.ReadLine());

double z1 = (Sin(a) + Cos(2 * b - a)) 
    / (Cos(a) - Sin(2 * b - a));

double z2 = (1 + Sin(2 * b))
    / (Cos(2 * b));

Console.WriteLine($"z1: {z1:.###}, z2: {z2:.###}");