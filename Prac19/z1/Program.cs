Stack<string> lines = new Stack<string>();

Console.Write("Введите текст: ");
lines.Push(Console.ReadLine());

while(lines.Count != 0)
{
    Console.WriteLine(ExecuteBackspaceLit(lines.Pop()));
}

string ExecuteBackspaceLit(string str)
{
    while(str.IndexOf('#') != -1)
    {
        if(str.IndexOf('#') != 0)
        {
            str = str.Remove(str.IndexOf('#') - 1, 2);
        }
        else
        {
            str = str.Remove(str.IndexOf('#'), 1);
        }
    }

    return str;
}