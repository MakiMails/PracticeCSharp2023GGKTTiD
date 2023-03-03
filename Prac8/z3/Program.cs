//using System.Text.RegularExpressions;

//Console.Write("Введите текст :");
//string text = Console.ReadLine();

//if (CheckWhetherNumber(text))
//{
//    Console.WriteLine("В тексте есть числа");
//}
//else
//{
//    Console.WriteLine("В тексте нет чисел");
//}

//bool CheckWhetherNumber(string text)
//{
//    Regex regex = new Regex(@"\d");
//    MatchCollection words = regex.Matches(text);
//    if (words.Count != 0)
//    {
//        return true;
//    }
//    return false;
//}


//using System.Text.RegularExpressions;

using System.Text.RegularExpressions;

//string pattern = @"([0-1][1-9]|2[0-9]|3[0-1]).(0[1-9]|1[0-2]).([1-2]+0+[0-1]+[0-9]|[1-2]+02+[0-3])";
//string input = Console.ReadLine();

//if (Regex.IsMatch(input, pattern))
//{
//    Console.WriteLine("Работает");
//}

//string pattern = @"[bcdfghjklmnpqrstvwxz](\w{1})\1{1,1}";
//string input = Console.ReadLine();


//foreach (Match m in Regex.Matches(input, pattern))
//{
//    Console.WriteLine(m.Value);
//}

//foreach (Match m in Regex.Matches(input, pattern, options))
//{
//    Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);
//}



//Console.Write("Введите n: ");
//int n = Convert.ToInt32(Console.ReadLine());

//string[] offers = text.Split('.');

//Regex regex = new Regex(@"\w+");
//foreach (string offer in offers)
//{
//    MatchCollection words = regex.Matches(offer);
//    if(words.Count >= n)
//    {
//        Console.WriteLine(offer);
//    }
//}

string pattern = @"[^\saeiou]{3}";
string input = @"gggsdf sdfaaasdww asdaaasdw asdfafsdfsdffa redasd asddwwda";
RegexOptions options = RegexOptions.Multiline | RegexOptions.IgnoreCase;

foreach (Match m in Regex.Matches(input, pattern, options))
{
    Console.WriteLine("'{0}' найдено в позиции {1}.", m.Value, m.Index);
}