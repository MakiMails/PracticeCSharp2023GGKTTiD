//Дано трехзначное число. В нем зачеркнули последнюю справа
//цифру и приписали ее в начале. Найти полученное число.

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (100 <= num && num <= 999)
{
    Console.WriteLine($"{(num % 10) * 100 + (num / 10) % 100}");
}
else
{
    Console.WriteLine("Введино не трехзначное число");
}
