const string Alphabet = @"абвгдеёжхийклмнопрстуфхцчшщъыьэюя";
Console.Write("Введите ФИО: ");
string[] fullName = Console.ReadLine().Split(' ');
int num = 0;
foreach (string word in fullName)
{
    num += SumIndexInStr(word);
}
int code = ToDetermineCodeNumber(num);
Console.WriteLine($"{code}");

int SumIndexInStr(string str)
{
    int num = 0;
    string strLower = str.ToLower();
    for (int i = 0; i < strLower.Length; i++)
    {
        num += Alphabet.IndexOf(strLower[i]) + 1;

    }
    return num;
}

int ToDetermineCodeNumber(int num)
{
    int code = 0;
    while (num != 0)
    {
        code += num % 10;
        num /= 10;
        if (code > 9 && num == 0)
        {
            num = code;
            code = 0;
        }
    }

    return code;
}