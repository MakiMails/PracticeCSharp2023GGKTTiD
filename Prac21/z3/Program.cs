Console.Write("Write number: ");
int num = Convert.ToInt32(Console.ReadLine());

Task<int> taskCalculation = new Task<int>(() => { return ReverseNum(num); });
taskCalculation.Start();
taskCalculation.Wait();
Task taskWriteResult = new Task(() => { Console.WriteLine($"Result: {taskCalculation.Result}"); });
taskWriteResult.Start();

int ReverseNum(int num)
{
    if((10 < num && num <= 99) || (-99 <= num && num < -10))
    {
        return num % 10 * 10 + num / 10;
    }
    else
    {
        throw new Exception("Number is not range(11, 99) or range(-99,-11).");
    }
}