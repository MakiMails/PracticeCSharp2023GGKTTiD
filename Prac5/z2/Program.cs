try
{
    Console.Write("Введите x: ");
    double x = Convert.ToInt32(Console.ReadLine());

    Console.Write("Ответ: ");
    if(-4 < x && x < 1 )
    {
        Console.WriteLine($"{3 * x / (x - 2)}");
    }
    else if(1 <= x)
    {
        Console.WriteLine(3);
    }
    else
    {
        throw new Exception("x не входит в диапозон");
    }
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
}
catch (FormatException ex)
{
    Console.WriteLine(ex.Message);
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}