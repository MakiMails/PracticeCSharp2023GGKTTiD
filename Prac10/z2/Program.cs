using z2.Model;

RailwayStation rs = new RailwayStation(10);

ConsoleWriteLineGreen("List of trains: ");
rs.WriteAllsTrains();

ConsoleWriteLineGreen("Enter the index: ");
int index = Convert.ToInt32(Console.ReadLine());
rs.WriteTrainByIndex(index);

ConsoleWriteLineGreen("Enter the time: ");
Console.Write("Рour: ");
int hour = Convert.ToInt32(Console.ReadLine());
Console.Write("Minute: ");
int minute = Convert.ToInt32(Console.ReadLine());
WriteArrayTrainByTime(rs,new TimeOnly(hour, minute));

ConsoleWriteLineGreen("Enter your destination: ");
string destination = Console.ReadLine();
WriteArrayTrainByDestination(rs, destination);

Console.WriteLine($"{rs[1] > rs[0]}");
rs.WriteTrainByIndex(1);
rs.WriteTrainByIndex(0);

void ConsoleWriteLineGreen(string mes)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(mes);
    Console.ForegroundColor = ConsoleColor.White;
}

void WriteArrayTrainByTime(RailwayStation rs, TimeOnly time)
{
    rs.WriteTrains(rs.GetArrayTrainByTime(time));
}

void WriteArrayTrainByDestination(RailwayStation rs, string destination)
{
    rs.WriteTrains(rs.GetArrayTrainByDestination(destination));
}