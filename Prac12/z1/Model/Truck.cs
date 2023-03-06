namespace z1.Model
{
    internal class Truck : Car
    {
        private double _loadCapacity;

        public Truck(string name, double loadCapacity) : base(name)
        {
            _loadCapacity = loadCapacity;
        }

        public override double GetFuelConsumption() => Math.Sqrt(_loadCapacity) * 100;
    }
}
