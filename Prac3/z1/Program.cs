using z1.Models;

Console.Write("Введите а: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b: ");
int numB = Convert.ToInt32(Console.ReadLine());

A a = new A(numA, numB);

Console.WriteLine($"вызов метода среднего арифметического чисел: {a.GetArithmeticMean()}");
Console.WriteLine($"вызов метода пример чисел: {a.GetValueExample():.###}");