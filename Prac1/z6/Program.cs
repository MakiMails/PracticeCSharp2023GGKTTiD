Console.Write("Введите двухзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (10 <= num && num <= 100)
{
    Console.WriteLine($"Результат: {((num % 10) * 10) + ((num / 10) % 10)}");
}
else
{
    Console.WriteLine($"Число {num} не является двухзчным");
}
