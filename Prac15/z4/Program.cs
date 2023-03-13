Console.Write("Введите последнее число последовательности: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[num];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = i + 1;
}

int countThread = GetCountThread(num);


Thread[] threads = new Thread[countThread];
int[] arrResultThreads = new int[countThread];
int startWith = 0;
int sizePart = 5;
for (int i = 0; i < countThread; i++)
{
    if (sizePart + startWith > arr.Length)
    {
        sizePart = arr.Length - startWith;
    }
    int[] partArr = new int[sizePart];
    Array.Copy(arr, startWith, partArr, 0, partArr.Length);
    startWith += sizePart;
    int numThread = i;
    threads[i] = new Thread(() =>
    {
        
        arrResultThreads[numThread] = SumEvenElemInArr(partArr);
    });
    threads[i].Start();
}

foreach (Thread thread in threads)
{
    thread.Join();
}

Console.WriteLine(arrResultThreads.Sum());

int SumEvenElemInArr(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}

int GetCountThread(int num) => num % 5 != 0 ? Convert.ToInt32(num / 5) + 1 : num / 5;
