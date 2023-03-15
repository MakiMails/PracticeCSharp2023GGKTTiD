using Z1Lib;

Console.WriteLine("Введите сторона прямоугольника:");
Console.Write("   A - ");
double aR = Convert.ToDouble(Console.ReadLine());
Console.Write("   B - ");
double bR = Convert.ToDouble(Console.ReadLine());

Rectangle r1 = new Rectangle(aR, bR);
Console.WriteLine(r1.ToString());

Console.WriteLine("-------------------------------");

Console.WriteLine("Введите сторона треугольника:");
Console.Write("   A - ");
double aT = Convert.ToDouble(Console.ReadLine());
Console.Write("   B - ");
double bT = Convert.ToDouble(Console.ReadLine());
Console.Write("   C - ");
double cT = Convert.ToDouble(Console.ReadLine());

Triangle t1 = new Triangle(aT, bT, cT);
Console.WriteLine(t1.ToString());
