using static System.Math;

double x = 0.5;
double y = x * Exp(x * x)
    - ((Sin(Sqrt(x))
    + Pow(Cos(Log(x)), 2))
    / (Sqrt(Abs(1 - PI * x))));

Console.WriteLine($"Ответ: {y}");