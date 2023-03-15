//Создать текстовый файл, в который записать 5 строк различной длины.
//Для данного файла выполнить следующие действия:
//a) вывести весь файл на экран;
//b) подсчитать количество строк;
//c) подсчитать количество символов в каждой строке;
//d) удалить последнюю строку из файла, результат записать в новый
//файл;

//e) вывести на экран строки с s1 по s2;
//f) найти длину самой длинной строки и вывести ее на экран;
//g) вывести на экран все строки начинающиеся с заданной буквы;
//h) переписать его строки в другой файл, порядок строк во втором
//файле должен быть обратным по отношению к порядку строк в заданном
//файле.


string pathF1 = @"D:\PracticCSharp\Prac17\z3\Files\TextFile1.txt";
List<string> linesF1 = await GetTextFile(pathF1);
Console.WriteLine("Текст из 1 файла:");
WriteList(linesF1);
Console.WriteLine();
Console.WriteLine($"Кол-во строк в 1 файле: {linesF1.Count}");
Console.WriteLine();
Console.WriteLine("Размеры строк:");
List<int> countElemtInLines = CountElemtInLines(linesF1);
WriteList(countElemtInLines);
Console.WriteLine();
linesF1.RemoveAt(linesF1.Count - 1);
Console.WriteLine("Список поле удаления последнего элемента");
WriteList(linesF1);
string pathF2 = @"D:\PracticCSharp\Prac17\z3\Files\TextFile2.txt";
await RecordInFile(pathF2, linesF1);
Console.WriteLine("Список записан в файл 2");
Console.WriteLine();
Console.WriteLine($"Самая длинна строка: {linesF1.Max()}");

Console.Write("Введите букву для поиска строки: ");
char let = Convert.ToChar(Console.ReadLine());
Console.WriteLine($"Строчки начинающиеся на {let}:");
WriteList(GetLineBeginWith(linesF1, let));

string pathF3 = @"D:\PracticCSharp\Prac17\z3\Files\TextFile3.txt";
linesF1.Reverse();
await RecordInFile(pathF3,linesF1);
Console.WriteLine("В файл 3 записан реверснутый список");
//

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

async Task RecordInFile(string path, List<string> lines)
{
    using (StreamWriter writer = new StreamWriter(path, false))
    {
        foreach (string line in lines)
        {
            await writer.WriteLineAsync(line);
        }
    }
}

void WriteList<T>(List<T> list)
{
    foreach (T elim in list)
    {
        Console.WriteLine($"{elim}");
    }
}

List<int> CountElemtInLines(List<string> lines)
{
    List<int> countElem = new List<int>();
    foreach (string line in lines)
    {
        countElem.Add(line.Length);
    }
    return countElem;
}

List<string> GetLineBeginWith(List<string> lines, char ch) => lines.Where(l => l.StartsWith(ch)).ToList();