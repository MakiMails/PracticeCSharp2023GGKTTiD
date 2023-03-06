using z1.Model;

Field field = new Field("Базовый класс", 3.4);
Console.WriteLine("Базовый класс: ");
Console.WriteLine($"Название: {field.Name}");
Console.WriteLine($"R: {field.R}");

PotatoField potatoField = new PotatoField("Наследник Field", 4.4, 20);
Console.WriteLine("Наследник класса Field: ");
Console.WriteLine($"Название: {potatoField.Name}");
Console.WriteLine($"R: {potatoField.R}");
Console.WriteLine($"S: {potatoField.Square}");

Console.WriteLine($"Количество урожая с единицы площади(базовый класс):" +
    $" {field.GetCountHarvestPerUnitSquare(2)}");

Console.WriteLine($"Урожай со всего поля(класс наследник):" +
    $" {potatoField.GetCountHarvest(2)}");