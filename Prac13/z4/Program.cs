DelNum[] delNums = new DelNum[5];
for (int i = 0; i < 5; i++)
{
    delNums[i] = RandomNum;
}

AnanimnyMetod am = delegate (DelNum[] delNums)
{
    int sum = 0;
    for (int i = 0; i < delNums.Length; i++)
    {
        sum += delNums[i].Invoke();
    }
    return sum / delNums.Length;
};


Console.WriteLine($"Результат выполенения: {am(delNums)}");

static int RandomNum()
{
    Random random = new Random();
    return random.Next(0, 11);
}
delegate double AnanimnyMetod(DelNum[] delNums);
delegate int DelNum();
