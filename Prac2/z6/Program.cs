//Задание 7
Console.Write("Введите x: ");
decimal x = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("for");

for (int i = 10; i <= 200; i += 10) 
{
    Console.WriteLine($"Кол-во(шт.): {i} - Цена:{x * i}");
}

Console.WriteLine("while");

int z = 10;
while(z <= 200)
{
    Console.WriteLine($"Кол-во(шт.): {z} - Цена:{x * z}");
    z +=10;
}

Console.WriteLine("do...while");

int j = 0;
do
{
    j += 10;
    Console.WriteLine($"Кол-во(шт.): {z} - Цена:{x * j}");
   

} while(j < 200);