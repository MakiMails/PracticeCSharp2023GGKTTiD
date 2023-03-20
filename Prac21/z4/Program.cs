Parallel.For(-6, 4, Ctg);
void Ctg(int num) => Console.WriteLine(Math.Sin(num) / Math.Cos(num));
