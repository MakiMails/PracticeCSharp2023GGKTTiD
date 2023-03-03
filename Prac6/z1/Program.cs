Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array = GetRandomMatrix(n);

WriteMatrix(array);
Console.WriteLine();
int indexMinNum = GetIndexMinElemInArray(array);
Console.WriteLine($"Найменьшое число в матрице {array[indexMinNum]} под индексом {indexMinNum}");
    
int[] GetRandomMatrix(int n)
{
    int[] arr = new int[n];
    Random random = new Random();
    for (int i = 0; i < n; i++)
    {
        arr[i] = random.Next(1, 10);
    }
    return arr;
}

void WriteMatrix(int[] array)
{
    for (int i = 0; i < array.GetUpperBound(0) + 1; i++)
    {
        Console.Write($"{array[i]}\t");
        Console.WriteLine();
    }
}

int GetIndexMinElemInArray(int[] array)
{
    int[] arr2 = new int[array.Length];
    Array.Copy(array,arr2,array.Length);
    Array.Sort(arr2);

    return Array.IndexOf(array, arr2[0]);
}