try
{
    Console.Write("Введите x: ");
    double x = Convert.ToDouble(Console.ReadLine());
    double y = (5 * x - 7) / (x - 5);
    Console.WriteLine($"y: {y}");
    y = Math.Tan(y) + Math.Cos(x) / (x - 1);
    Console.WriteLine($"y: {y:.###}");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}