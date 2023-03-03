for (int i = 0; i < 3; i++)
{
    Console.Write("Введите x1:");
    double x1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите y1:");
    double y1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введите x2:");
    double x2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите y2:");
    double y2 = Convert.ToDouble(Console.ReadLine());
    RectPS(x1, y1, x2, y2, out double P, out double S);
    Console.WriteLine($"Периметр: {P}");
    Console.WriteLine($"Площадь: {S}");
    Console.WriteLine();
}

void RectPS(double x1, double y1, double x2, double y2,
    out double P, out double S)
{
    P = 0;
    S = 0;
    try
    {
        P = 2 * (x2 - x1 + y2 - y1);
        S = (x2 - x1) * (y2 - y1);
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
}