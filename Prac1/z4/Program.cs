//Три сопротивления R1, R2, R3 соединены
//параллельно. Найти сопротивление
//соединения.

Console.Write("Введите первое соправтивление R1: ");
double R1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите второе соправтивление R2: ");
double R2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите третье соправтивление R3: ");
double R3 = Convert.ToDouble(Console.ReadLine());

double R =  1/R1+ 1/R2 + 1/R3;

Console.WriteLine($"Общае сопративление:{R:.###}");