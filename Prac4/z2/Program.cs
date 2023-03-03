//y = f(x) для x - [a,b] с шагом h

Console.Write("Введите a: ");
double numA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b: ");
double numB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите шаг h: ");
double h = Convert.ToDouble(Console.ReadLine());

for (double i = numA; i <= numB; i += h)
{
    if (F.Fc(i) < 0)
    {
        //Задание 3
        F.Fc(i, out double y);
        Console.WriteLine($"x:{i} y:{y} a + b = {numA + numB}");
    }
    else if (0 <= F.Fc(i) && F.Fc(i) < 10)
    {
        Console.WriteLine($"x:{i} y:{F.Fc(i)} a - b = {numA - numB}");
    }
    else
    {
        Console.WriteLine($"x:{i} y:{F.Fc(i)} a * b = {numA * numB}");
    }
}



class F
{
    public static double Fc(double x) => x * x - 5 * x;

    //Задание 3
    public static void Fc(double x, out double y)
    {
        y = 0;
        y = x * x - 5 * x;
    }
}