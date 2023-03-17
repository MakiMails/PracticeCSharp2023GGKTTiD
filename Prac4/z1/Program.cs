///<summary>Импортирование класса Math</summary>
using static System.Math;

///<summary>Переменная объявления a</summary>
Console.Write("Введите a: ");
double numA = Convert.ToDouble(Console.ReadLine());
///<summary>Переменная объявления a</summary>
Console.Write("Введите b: ");
double numB = Convert.ToDouble(Console.ReadLine());


///<summary> 
///Данная проверка нужна для определения
///наименьшего значения возращаемся методом<c>Func(double x)</c>
///</summary>
if (Func(numA) > Func(numB)) 
{
    Console.WriteLine($"В точке b:{numB} со значением y:{Func(numB):.###} " +
        $"функция принимает наименьшее значение");
}
else
{
    Console.WriteLine($"В точке a:{numA} со значением y:{Func(numA):.###} " +
        $"функция принимает наименьшее значение");
}


///<param name="x">число x по которому ьудет находится 
///значение функции</param>
///<returns>возращает результат выполнения функции
///cos(2x) + sin(x - 3)</returns>
double Func(double x) => Cos(2 * x) + Sin(x - 3);

