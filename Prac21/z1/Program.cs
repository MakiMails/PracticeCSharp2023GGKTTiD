Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

Task.Run(() => Console.WriteLine(g(num)));

async Task<int> g(int num)=>num % 10 * 100 + num / 10;
