//Задание 3
Console.Write("Введите цену за кг канфет: ");
double price = Convert.ToDouble(Console.ReadLine());
if (1 <= price && price <= 100)
{
    for (double i = 0.1; i <= 1; i += 0.1)
    {
        Console.WriteLine($"Кол-во кг канфет: {i:.##} цена: {(price * i):.####}");
    }
}
else
{
    Console.WriteLine("Число выхожит за предел 1..100");
}