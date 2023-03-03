using z4.Model;

Console.Write("Введите i: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите j: ");
int j = Convert.ToInt32(Console.ReadLine());

RealMatrix rm = new RealMatrix(i, j);
rm.Write();
Console.WriteLine();

RealMatrix rm2 = new RealMatrix(i, j);
rm2.Write();
Console.WriteLine();

var rm3 = rm + rm2;
rm3.Write();
Console.WriteLine();
rm3 += 3;
rm3.Write();
Console.WriteLine();
rm3 -= 5;
rm3.Write();
Console.WriteLine();

Console.WriteLine($"Кол-во элементов в rm3 {rm3.CountElem}");
Console.WriteLine($"элемент 1 1 в rm3 = {rm3[1,1]}");