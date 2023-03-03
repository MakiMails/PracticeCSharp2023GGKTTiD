//запрашивает с клавиатуры два вещественных числа, и выводит на
//экран результат деления первого числа на второе (вещественные числа
//выводятся с точностью до 3 знаков после запятой)

Console.Write("Введите a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b: ");
double b = Convert.ToDouble(Console.ReadLine());
double c = a/b;
Console.WriteLine($"{a}/{b}={c:.###}");