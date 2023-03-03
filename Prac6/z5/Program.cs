Console.Write($"Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Factorial(n - 1) / Factorial(n  - 2));

int[] arr = new int[5];

int Factorial(int num)
{
    if(num == 0)
    {
        return 1;
    }
    else
    {
        return num * Factorial(num - 1);
    }
}


