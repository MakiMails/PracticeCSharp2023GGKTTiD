Console.Write("Введите строчку: ");
string str = Console.ReadLine();

WorkerString ws = ToUpper;
ws += Trim;
ws += ToLower;

Console.WriteLine($"Результат выполнения: {ws(str)}");


static string ToUpper(string str) => str.ToUpper(); 
static string ToLower(string str) => str.ToLower();
static string Trim(string str) => str.Trim();

delegate string WorkerString(string str);