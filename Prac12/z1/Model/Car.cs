namespace z1.Model
{
    internal abstract class Car
    {
        private string _name;
        public string Name { get=> _name; }

        public Car(string name)
        {
            _name = name;
        }

        public virtual double GetFuelConsumption() => 5;

        public static double GetAverageConsumption(Car[] cars)
        {
            if (cars != null)
            {
                double allsFuel = 0;
                foreach (Car car in cars)
                {
                    allsFuel += car.GetFuelConsumption();
                }
                return allsFuel;
            }
            throw new Exception("Array is null");
        }
    }
}
