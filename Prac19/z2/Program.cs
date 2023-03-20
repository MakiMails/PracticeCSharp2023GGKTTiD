using System.Text.RegularExpressions;

string path = @"D:\PracticCSharp\Prac19\z2\Files\TextFile1.txt";

int a = Convert.ToInt32(Print("Введите a: "));
int b = Convert.ToInt32(Print("Введите b: "));

List<int> nums = GetNumsInListStr(await GetTextFile(path));

WriteList(nums);
Console.WriteLine("Числа входящие в диапазон от a до b");
WriteList(FindNumInRange(nums, a, b));
Console.WriteLine("Меньше a:");
WriteList(FindNumsLessNum(nums, a));
Console.WriteLine("Больше b: ");
WriteList(FindNumsGreaterNum(nums, b));

string Print(string mes = "")
{
    Console.Write(mes);
    return Console.ReadLine();
}

async Task<List<string>> GetTextFile(string path)
{
    using (StreamReader reader = new StreamReader(path))
    {
        string? line;
        List<string> lines = new List<string>();

        while ((line = await reader.ReadLineAsync()) != null)
        {
            lines.Add(line);
        }
        return lines;
    }
}

void WriteList<T>(List<T> list)
{
    foreach (T elem in list)
    {
        Console.Write($"{elem} ");
    }
    Console.WriteLine();
}

List<int> GetNumsInListStr(List<string> lines)
{
    List<int> nums = new List<int>();

    Regex regex = new Regex(@"\d+");

    foreach(string line in lines)
    {
        MatchCollection matches = regex.Matches(line);
        foreach(var num in matches)
        {
            nums.Add(Convert.ToInt32(num.ToString()));
        }
    }

    return nums;
}

List<int> FindNumInRange(List<int> nums,int a, int b) =>nums.Where(n => a <= n && n <= b).ToList();

List<int> FindNumsLessNum(List<int> nums, int num) => nums.Where(n => n <= num).ToList();
List<int> FindNumsGreaterNum(List<int> nums, int num) => nums.Where(n => n >= num).ToList();

