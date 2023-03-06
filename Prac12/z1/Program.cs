using z1.Model;

Car[] cars = new Car[]
{
    new PassengerCar("BMW",1.1),
    new PassengerCar("Audi",3.5),
    new Truck("ВАЗ",0.5),
    new Truck("ss",1),
    new PassengerCar("Nisan",5.0)
};

foreach(Car car in cars)
{
    Console.WriteLine($"Расход томлива на 100км: {car.GetFuelConsumption():.###}");
}

Console.WriteLine($"Cуммарного расхода горючего: {Car.GetAverageConsumption(cars)}");