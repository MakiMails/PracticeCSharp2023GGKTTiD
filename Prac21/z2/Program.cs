using static System.Math;

Console.Write("Write number a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Write time sleep for Task: ");
int n = Convert.ToInt32(Console.Read());

Task[] tasks = GetArrTasks();
Console.WriteLine("Waiting for one completed Task from an array:");
foreach (Task t in tasks)
{
    t.Start();
}
Task.WaitAny(tasks);

Task[] tasks2 = GetArrTasks();
Console.WriteLine("Waiting for all Tasks from the array: ");
foreach (Task t in tasks2)
{
    t.Start();
}
Task.WaitAll(tasks2);


double Func1(double a) =>
    (Cos(a) + Sin(a)) / (Cos(a) - Sin(a));

double Func2(double a) =>
    Tan(2 * a) + Sin(2 * a);

Task[] GetArrTasks() => new Task[]
{
    new Task(() => { Thread.Sleep(n); Console.WriteLine($"Func1: {Func1(a):.###}"); }),
    new Task(() => { Console.WriteLine($"Func2: {Func2(a):.###}"); })
};
