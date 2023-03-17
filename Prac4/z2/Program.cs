///<summary>Обявление переменных a, b, h(шаг)</summary>
Console.Write("Введите a: ");
double numA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b: ");
double numB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите шаг h: ");
double h = Convert.ToDouble(Console.ReadLine());

///<summary>
///цикл фор нанчинает отсчет с <c>numA</c>> до <c>numB</c> ключительно с
///шагом <c>h</c>
/// </summary>
for (double i = numA; i <= numB; i += h)
{
    if (F.Fc(i) < 0)
    {
        //Задание 3
        F.Fc(i, out double y);
        Console.WriteLine($"x:{i} y:{y} a + b = {numA + numB}");
    }
    else if (0 <= F.Fc(i) && F.Fc(i) < 10)
    {
        Console.WriteLine($"x:{i} y:{F.Fc(i)} a - b = {numA - numB}");
    }
    else
    {
        Console.WriteLine($"x:{i} y:{F.Fc(i)} a * b = {numA * numB}");
    }
}


/// <summary>
/// Класс <c>F</c> предназначен ля содержания функций
/// </summary>
class F
{
    /// <summary>
    /// Считает функцию по заданному x по формуле x^2 - 5 * x
    /// </summary>
    /// <param name="x">переменная покоторой ведется расчет фк</param>
    /// <returns></returns>
    public static double Fc(double x) => x * x - 5 * x;

    //Задание 3
    /// <summary>
    /// Перегрузка основного метода Fc с изменеными параметрами
    /// и с типом возращаемых данных void
    /// </summary>
    /// <param name="x">Переменная покоторой ведется расчет</param>
    /// <param name="y">Выходной параметр, который высчитывается 
    /// по формуле x^2 - 5 * x</param>
    public static void Fc(double x, out double y)
    {
        y = 0;
        y = x * x - 5 * x;
    }
}