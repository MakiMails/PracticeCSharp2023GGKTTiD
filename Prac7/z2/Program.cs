using System.Text.RegularExpressions;

Console.Write("Введите числа: ");
string text = Console.ReadLine();

Dictionary<int, int> nums = CountNumberOfNumbersIsStr(text);
WriteDictionary(nums);
int keyOfMaxValue = GetKeyAtMaxValueInDictionary(nums);
Console.WriteLine();
Console.WriteLine("Чаще всего повторялось: ");
Console.WriteLine($"Ключ: {keyOfMaxValue}  Значение: {nums[keyOfMaxValue]}");

Dictionary<int, int> CountNumberOfNumbersIsStr(string text)
{
    Regex regex = new Regex(@"[\w]+");
    MatchCollection matches = regex.Matches(text);


    Dictionary<int, int> nums = new Dictionary<int, int>();
    foreach (Match match in matches)
    {
        Console.WriteLine(match.Value);
        if (Int32.TryParse(match.Value, out int num))
        {
            if (nums.TryGetValue(num, out int value))
            {
                nums[num]++;
            }
            else
            {
                nums.Add(num, 1);
            }
        }
    }
    return nums;
}

void WriteDictionary(Dictionary<int, int> nums)
{
    foreach (var num in nums)
    {
        Console.WriteLine($"Ключ: {num.Key}  Значение: {num.Value}");
    }
}

int GetKeyAtMaxValueInDictionary(Dictionary<int, int> nums) => nums.Aggregate
    ((x, y) => x.Value >= y.Value ? x : y).Key;