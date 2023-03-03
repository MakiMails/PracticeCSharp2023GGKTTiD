Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] arr = GetArray(n);

Console.WriteLine($"Массив: ");
WriteArray(arr);
Console.WriteLine($"Сумма положительных чисел в массиве: {GetSumArray(arr)}");
Console.WriteLine($"Кол-во отрицательных чисел: {GetCountNegativeNumInArr(arr)}");
Console.WriteLine($"Кол-во нулей: {GetCountZeroInArr(arr)}");


int[] GetArray(int n)
{
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = i;
    }
    return arr;
}

void WriteArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}\t");
    }
    Console.WriteLine();
}

int GetSumArray(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}

int GetCountNegativeNumInArr(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            count += arr[i];
        }
    }
    return count;
}

int GetCountZeroInArr(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == 0)
        {
            count++;
        }
    }
    return count;
}