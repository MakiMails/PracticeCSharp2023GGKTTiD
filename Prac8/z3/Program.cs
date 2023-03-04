using System.Text.RegularExpressions;

Console.Write("Введите текст :");
string text = Console.ReadLine();

if (CheckWhetherNumber(text))
{
    Console.WriteLine("В тексте есть числа");
}
else
{
    Console.WriteLine("В тексте нет чисел");
}

bool CheckWhetherNumber(string text)
{
    Regex regex = new Regex(@"\d");
    MatchCollection words = regex.Matches(text);
    if (words.Count != 0)
    {
        return true;
    }
    return false;
}