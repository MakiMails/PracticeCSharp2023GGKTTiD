bool thereIsChoice = true;
ArithmeticOperation ao =  delegate(double x, double y) { return 0; };
do
{
    Console.WriteLine("1 - Sum | 2 - Sub | 3 - Mul | 4 - Div");
    Console.WriteLine("Любое другое число является выходом");
    Console.WriteLine();
    Console.Write("Введите номер операции: ");
    int operationNum = Convert.ToInt32(Console.ReadLine());

    if (operationNum == 1)
    {
        ao += Add;
    }
    else if (operationNum == 2)
    {
        ao += Sub;
    }
    else if (operationNum == 3)
    {
        ao += Mul;
    }
    else if (operationNum == 4)
    {
        ao += Div;
    }
    else
    {
        thereIsChoice = false;
    }


} while (thereIsChoice);


Console.Write("Введите num1: ");
double num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите num2: ");
double num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Результат выполнения делегата: {ao(num1,num2)}");

static double Add(double num1, double num2) => num1 + num2;
static double Sub(double num1, double num2) => num1 - num2;
static double Mul(double num1, double num2) => num1 * num2;
static double Div(double num1, double num2) => num2 != 0 ? num1 / num2 :
    throw new Exception("Division by zero is not possible");

delegate double ArithmeticOperation(double num1, double num2);