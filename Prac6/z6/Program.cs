int N = 7, M = 7;
int[,] A = new int[N, M];


//Заносим значения в массив

int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = M;

for (int i = 0; i < A.Length; i++)
{
    A[col, row] = i + 1;
    if (--gran == 0)
    {
        gran = M * (dirChanges % 2) + N * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
        int temp = dx;
        dx = -dy;
        dy = temp;
        dirChanges++;
    }
    col += dx;
    row += dy;
}

//Выводим на консоль
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        Console.Write(A[i, j] + " ");
    }
    Console.WriteLine();
}