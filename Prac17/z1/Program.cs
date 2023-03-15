//Дан файл f, компонентами которого являются натуральные числа.
//Получить в файле g все компоненты файла f, делящиеся на 3.

string pathF = @"D:\PracticCSharp\Prac17\z1\Files\f.txt";
List<int> nums = await GetNumsDiv3InFile(pathF);
string pathG = @"D:\PracticCSharp\Prac17\z1\Files\g.txt";
await WriteNumToFile(pathG, nums);

async Task<List<int>> GetNumsDiv3InFile(string path)
{
    using (StreamReader reader = new StreamReader(path))
    {
        string? line;
        List<int> nums = new List<int>();

        while ((line = await reader.ReadLineAsync()) != null)
        {
            string[] elements = line.Split(' ');

            for (int i = 0; i < elements.Length; i++)
            {
                if (int.TryParse(elements[i], out int num))
                {
                    if (num % 3 == 0)
                    {
                        nums.Add(num);
                    }
                }
            }
        }
        return nums;
    }
}

async Task WriteNumToFile(string path,List<int> nums)
{
    string line = "";

    foreach(int num in nums)
    {
        line += num + " ";
    }

    using (StreamWriter writer = new StreamWriter(path, false))
    {
        await writer.WriteLineAsync(line);
    }
}

