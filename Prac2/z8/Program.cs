//Задание 9

double a = Math.PI / 4;
double b = Math.PI / 2;
int m = 15;
double h = (b - a) / m;

Console.Write("Введите x: ");
double x = Convert.ToDouble(Console.ReadLine());
for (double i = a ; i <= b; i+=h)
{
    double y = 1 / Math.Tan(x);
    Console.WriteLine($"x:{i:.###} - y:{y:.###}");
    x = i + h;
}

