namespace Z1Lib
{
    public class Triangle : Figure
    {
        private double _a;
        private double _b;
        private double _c;

        public double A { get => _a; }
        public double B { get => _b; }
        public double C { get => _c; }

        public TriangleType Type { get; }

        public Triangle(double a, double b, double c)
        {
            if (CheckingForExistence(a, b, c))
            {
                _a = a;
                _b = b;
                _c = c;
                Type = DetermineType();
            }
            else
            {
                throw new Exception("Данный треугольник не модежет существовать.\n" +
                    "Треугольник существует только тогда, когда сумма двух его сторон больше третьей.");
            }
        }

        public override double CalculatePerimeter() => _a + _b + _c;

        public override double CalculateSquare()
        {
            double p = CalculatePerimeter() / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        public override string ToString()
        {
            return $"Тип треугольника: \n" +
                $"Стороны\n" +
                $"  А:{_a}\n" +
                $"  B:{_b}\n" +
                $"  C:{_c}\n" +
                $"Периметр: {CalculatePerimeter()}\n" +
                $"Площадь: {CalculateSquare():.###}";
        }

        private bool CheckingForExistence(double a, double b, double c) => a + b > c && b + c > a && a + c > b;

        private TriangleType DetermineType()
        {
            if (_a != _b && _a != _c && _b != _c)
            {
                return TriangleType.Versatile;
            }
            else if (_a == _b && _a == _c && _b == _c)
            {
                return TriangleType.Equilateral;
            }
            else
            {
                return TriangleType.Isosceles;
            }
        }

    }
}
