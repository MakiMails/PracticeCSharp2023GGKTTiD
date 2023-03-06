namespace z1.Model
{
    internal class Field
    {
        private string _name;
        private double _r;

        public string Name { get => _name; }
        public double R { get => _r; }

        public Field(string name, double r)
        {
            _name = name;
            _r = r;
        }

        public double GetCountHarvestPerUnitSquare(double k) => _r *k; 
    }
}
