Console.Write("Write number: ");
int num = Convert.ToInt32(Console.ReadLine());

//first
Task<int> ts1 = new Task<int>(() => { return ReverseNum(num); });
ts1.Start();
ts1.Wait();
Console.WriteLine(ts1.Result);
//Second
Task.Run(() => Console.WriteLine(ReverseNum(num)));
//Third
Task task = Task.Factory.StartNew(() => Console.WriteLine(ReverseNum(num)));

int ReverseNum(int num)=>num % 10 * 100 + num / 10;
