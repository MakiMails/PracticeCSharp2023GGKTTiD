using Z2Lib.Model;
using Z2Lib.Enum;

Console.WriteLine("Заполните данные: ");
string name = Print("Название: ");
int year = Convert.ToInt32(Print("Год выпуска: "));
GenereType genere = (GenereType)Enum.Parse(typeof(GenereType), Print("Введите жанр: "));
string nameCompany = Print("Название компании(издатель): ");
int numOfCopiesSold = Convert.ToInt32(Print("Кол-во продоных копий: "));
decimal cost = Convert.ToDecimal(Print("Стоимость: "));

Game game = new Game(name, year, genere, new Company(nameCompany),
    numOfCopiesSold, cost);
Console.WriteLine();
Console.WriteLine(game);

string Print(string mes = "")
{
    Console.Write(mes);
    return Console.ReadLine();
}
