namespace z1.Model
{
    internal class PassengerCar : Car
    {
        private double _engineCapacity;

        public PassengerCar(string name, double engineCapacity) : base(name)
        {
            _engineCapacity = engineCapacity;
        }

        public override double GetFuelConsumption() => 2.5 * _engineCapacity;
    }
}
