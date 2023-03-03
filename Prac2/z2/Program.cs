//Задание 2
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (100 <= num && num <= 999)
{
    if (num % 2 == 0)
    {
        Console.WriteLine("Число является трехзначным четным");
    }
    else
    {
        Console.WriteLine("Число являеться трехзначным нечетным");
    }
}
else
{
    Console.WriteLine("Данное число не являеться трехзначным");
}