List<int> nums = new List<int>() { 11, 12, 15, 68 };
Console.WriteLine($"Sum: {Sum(nums)}");

int Sum(List<int> nums)
{
    int sum = 0;
    Parallel.ForEach(nums, number => 
    {
        sum += number;
    });
    return sum;
}