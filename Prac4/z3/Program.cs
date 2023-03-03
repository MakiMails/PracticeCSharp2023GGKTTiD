using z3.Model;


Console.Write("Введите i: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите j: ");
int j = Convert.ToInt32(Console.ReadLine());

TwodimensionalArray twArray = new TwodimensionalArray(i, j);
twArray.Write();
Console.WriteLine();

TwodimensionalArray twArray2 = new TwodimensionalArray(i, j);
twArray2.Write();
Console.WriteLine();

var twArray3 = twArray + twArray2;
twArray3.Write();
Console.WriteLine();

Console.WriteLine($"Кол-во элементов в twArray3 {twArray3.CountElem}");