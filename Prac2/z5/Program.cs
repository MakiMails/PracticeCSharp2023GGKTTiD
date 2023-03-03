//Задание 6
using Bogus;

Console.Write("Введите пол м-мужской, ж-женский: ");
char simPol = Console.ReadLine()[0];

if(simPol == 'м')
{
    Faker f = new Faker("ru");
    for (int i = 0; i < 5; i++)
    {
        string name = f.Name.FirstName(Bogus.DataSets.Name.Gender.Male);
        Console.WriteLine(name); 
    }
}
else
{
    Faker f = new Faker("ru");
    for (int i = 0; i < 5; i++)
    {
        string name = f.Name.FirstName(Bogus.DataSets.Name.Gender.Female);
        Console.WriteLine(name);
    }
}