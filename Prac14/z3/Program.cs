using z3.Model;

Console.Write("Введите имя: ");
string name = Console.ReadLine();
MyInfo myInfo = new MyInfo(name);

Console.Write($"{myInfo.Name} заменить на: ");
myInfo.Name =  Console.ReadLine();
