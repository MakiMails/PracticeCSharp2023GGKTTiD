using Bogus;

namespace z2.Model
{
    internal class RailwayStation
    {
        private Train[] _trains;

        public RailwayStation(int countTrain)
        {
            _trains = GetRandom(countTrain);
            Array.Sort(_trains);
        }

        public void WriteAllsTrains()
        {
            foreach (Train train in _trains)
            {
                Console.WriteLine($"Destination: {train.Destination}");
                Console.WriteLine($"Number: {train.Number}");
                Console.WriteLine($"Departure Time: {train.DepartureTime}");
                Console.WriteLine();
            }
        }

        public void WriteTrains(Train[] trains)
        {
            foreach (Train train in trains)
            {
                Console.WriteLine($"Destination: {train.Destination}");
                Console.WriteLine($"Number: {train.Number}");
                Console.WriteLine($"Departure Time: {train.DepartureTime}");
                Console.WriteLine();
            }
        }

        public void WriteTrainByIndex(int i)
        {
            Console.WriteLine($"Destination: {_trains[i].Destination}");
            Console.WriteLine($"Number: {_trains[i].Number}");
            Console.WriteLine($"Departure Time: {_trains[i].DepartureTime}");
            Console.WriteLine();
        }

        public Train[] GetArrayTrainByTime(TimeOnly time)
        {
            var sortTrain = from t in _trains
                     where t.DepartureTime >= time
                     select t;
            return sortTrain.ToArray();
        }

        public Train[] GetArrayTrainByDestination(string destination)
        {
            var sortTrain = from t in _trains
                            where t.Destination == destination
                            select t;
            return sortTrain.ToArray();
        }

        private Train[] GetRandom(int countTrain)
        {
            Train[] trains = new Train[countTrain];
            Faker faker = new Faker();
            Random random = new Random();
            for(int i = 0; i < trains.Length; i++)
            {
                Train train = new Train(faker.Address.City(),
                    random.Next(100, 999).ToString(),
                    new TimeOnly(random.Next(0,13), random.Next(0, 60)));
                trains[i] = train;
            }
            return trains;
        }
    }
}
