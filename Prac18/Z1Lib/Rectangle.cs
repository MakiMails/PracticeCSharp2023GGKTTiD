namespace Z1Lib
{
    public class Rectangle : Figure
    {
        private double _a;
        private double _b;

        public double A { get => _a; }
        public double B { get => _b; }

        public Rectangle(double a, double b)
        {
            _a = a;
            _b = b;
        }

        public override double CalculatePerimeter() => _a * 2 + _b * 2;

        public override double CalculateSquare() => _a * _b;

        public override string ToString()
        {
            return $"Стороны:\n" +
                $"  A:{_a}\n" +
                $"  B:{_b}\n" +
                $"Периметр: {CalculatePerimeter()}\n" +
                $"Площадь: {CalculateSquare():.###}";
        }
    }
}
