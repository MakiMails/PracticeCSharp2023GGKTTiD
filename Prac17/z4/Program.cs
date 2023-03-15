string pathF1 = @"D:\PracticCSharp\Prac17\z4\Files\TextFile1.txt";
string pathF2 = @"D:\PracticCSharp\Prac17\z4\Files\TextFile2.txt";

List<string> linesF1 = await GetTextFile(pathF1);
RepleseList('0', '1', ref linesF1);
await RecordInFile(pathF2, linesF1);

List<string> linesF2 = await GetTextFile(pathF2);
RepleseList('1', '0', ref linesF2);
await RecordInFile(pathF1, linesF2);


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

void RepleseList(char oldChar, char newChar,ref List<string> list)
{
    for (int i = 0; i < list.Count; i++)
    {
        list[i] = list[i].Replace(oldChar, newChar);
    }
}

void WriteList(List<string> list)
{
    foreach (string elem in list)
    {
        Console.WriteLine(elem);
    }
}