Console.Write("Цена тетради (руб.): ");
decimal priceNotebook = Convert.ToDecimal(Console.ReadLine());
Console.Write("Цена обложки (руб.): ");
decimal priceCover = Convert.ToDecimal(Console.ReadLine());
Console.Write("Количество комплектов (шт.): ");
int numSets = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Итоговая цена: {(priceNotebook + priceCover) * numSets}");