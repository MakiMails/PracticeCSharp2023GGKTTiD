using static System.Math;

Console.Write("Введите a: ");
double numA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b: ");
double numB = Convert.ToDouble(Console.ReadLine());

if (Func(numA) > Func(numB)) 
{
    Console.WriteLine($"В точке b:{numB} со значением y:{Func(numB):.###} " +
        $"функция принимает наименьшее значение");
}
else
{
    Console.WriteLine($"В точке a:{numA} со значением y:{Func(numA):.###} " +
        $"функция принимает наименьшее значение");
}

double Func(double x) => Cos(2 * x) + Sin(x - 3);

