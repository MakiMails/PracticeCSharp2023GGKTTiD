using Z1;
using MyLibrary;


Aeroflot[] aeroflots = new Aeroflot[3];

for (int i = 0; i < aeroflots.Length; i++)
{
    string destination = MyTool.Input("Введите пункт назначения: ");
    int flightNumber = Convert.ToInt32(MyTool.Input("Введите номер рейса: "));
    string typeAircraft = MyTool.Input("Введите тип самолета: "); ;

    aeroflots[i] = new Aeroflot(destination, flightNumber, typeAircraft);
}

var aeroflotsSort = aeroflots.OrderBy(a => a.Destination);

foreach (var a in aeroflotsSort)
{
    Console.WriteLine($"{a.Destination}");
}

string _typeAircraft = MyTool.Input("Введите тип самолета: ");

if(aeroflotsSort.Any(s => s.TypeAircraft == _typeAircraft))
{
    foreach(var a in aeroflotsSort)
    {
        if (a.TypeAircraft == _typeAircraft)
        {
            Console.WriteLine($"Пункт назначения: {a.Destination}");
            Console.WriteLine($"Номер рейса: {a.FlightNumber}");
            Console.WriteLine($"Тип самолета: {a.TypeAircraft}");
            Console.WriteLine();
        }
    }
}
else
{
    Console.WriteLine("Нет такого типа");
}
