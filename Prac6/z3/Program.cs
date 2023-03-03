Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
while ( n >= 10)
{
    Console.WriteLine("n должно быть меньше 10");
    Console.Write("Введите N: ");
    n = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Введите a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b: ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] matrix = GetRandomMatrix(n, a, b);
WriteMatrix(matrix);

Console.Write("Введите D: ");
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Кол-во чисел меньше {d} равно {GetCountElemLessNum(d, matrix)}");

Console.WriteLine("Среднее арифметическое элементов каждого столбца: ");
double[] arrAripheticColumMatrix = GetAripheticColumMatrix(matrix);
for(int i = 0; i < arrAripheticColumMatrix.Length; i++)
{
    Console.WriteLine($"Столбец {i} арифметическое {arrAripheticColumMatrix[i]}");
}

int[,] GetRandomMatrix(int n, int a, int b)
{
    int[,] matrix = new int[n, n];
    Random random = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = random.Next(a, b + 1);
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

int GetCountElemLessNum(int num, int[,] matrix)
{
    int count = 0;
    for (int i = 0; i < matrix.GetUpperBound(0) + 1; i++)
    {
        for (int j = 0; j < matrix.GetUpperBound(1) + 1; j++)
        {
            if(num > matrix[i, j])
            {
                count++;
            }
        }
    }
    return count;
}

double[] GetAripheticColumMatrix(int[,] matrix)
{
    double[] arrReselt = new double[matrix.GetUpperBound(0) + 1];
    for (int i = 0; i < matrix.GetUpperBound(1) + 1; i++)
    {
        for (int j = 0; j < matrix.GetUpperBound(0) + 1; j++)
        {
            arrReselt[i] += matrix[j, i];      
        }
        arrReselt[i] /= matrix.GetUpperBound(1) + 1;
    }
    return arrReselt;
}