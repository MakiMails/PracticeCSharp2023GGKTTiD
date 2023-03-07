CalcFigure cf = GetLength;
cf += GetArea;
cf += GetVolume;
Console.Write("Введите значение R: ");
int R = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Результат выполнения делегата: {cf(R):.###}");

static double GetLength(double R) => 2 * Math.PI * R;
static double GetArea(double R) => Math.PI * R * R;
static double GetVolume(double R) => 4 / 3 * Math.PI * R * R * R;

delegate double CalcFigure(double R);

