namespace z4.Model
{
    internal class Wages
    {
        private decimal _min;
        private decimal _max;

        public Wages(decimal min, decimal max)
        {
            _min = min;
            _max = max;
        }

        public override string ToString()
        {
            return 
                $"  Минимум: {_min} " + 
                $"  Максимум: {_max}";
        }
    }
}
