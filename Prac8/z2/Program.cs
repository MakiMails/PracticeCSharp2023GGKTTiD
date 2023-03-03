using System.Text.RegularExpressions;

Console.Write("Введите текст :");
string text = Console.ReadLine();

if (CheckWhetherHTMLCode(text))
{
    Console.WriteLine("Текст является  HTML кодом");
}
else
{
    Console.WriteLine("Текст не является  HTML кодом");
}

bool CheckWhetherHTMLCode(string text)
{
    string[] arrayHTMLTag = { "<html>", "<form>", "<h1>" };
    for (int i = 0; i < arrayHTMLTag.Length; i++)
    {
        Regex regex = new Regex(arrayHTMLTag[i]);
        if (regex.Matches(text).Count > 0)
        {
            return true;
        }
    }
    return false;
}