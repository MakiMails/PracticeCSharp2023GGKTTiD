using System.Text.RegularExpressions;

Console.Write("Введите текст: ");
string text = Console.ReadLine();

Regex regex = new Regex(@"[\w]+");
MatchCollection matches = regex.Matches(text);

List<string> words = new List<string>();
foreach (Match match in matches)
{
    words.Add(match.Value);
}
words.Reverse();
foreach (string word in words)
{
    Console.Write($"{word} ");
}