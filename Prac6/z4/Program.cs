int[,] places = GetRandomMatrix(23,40);

WriteMatrix(places);

Console.WriteLine("Свободные места в первом ряду: ");
int[] arrFreeSeats = FindFreeSeats(places,0);
foreach(int num in arrFreeSeats)
{
    Console.Write($"{num + 1} ");
}
Console.WriteLine();

int[,] GetRandomMatrix(int n, int m)
{
    int[,] matrix = new int[n, m];
    Random random = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix[i, j] = random.Next(0, 2);
        }
    }
    return matrix;
}

void WriteMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
    {
        for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[] FindFreeSeats(int[,] matrix, int rowNum)
{
    List<int> list = new List<int>();
    for(int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
    {
        if (matrix[rowNum, i] != 1)
        {
            list.Add(i);
        }
    }

    return list.ToArray();
}