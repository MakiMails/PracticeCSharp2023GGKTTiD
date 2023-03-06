namespace z1.Model
{
    internal class PotatoField : Field
    {
        private double _square;

        public double Square { get => _square; }

        public PotatoField(string name, double r, double square) : base(name, r)
        {
            _square = square;
        }

        public double GetCountHarvest(double k)=> GetCountHarvestPerUnitSquare(k) * _square;
    }
}
