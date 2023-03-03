using static System.Math;
namespace z3.Models
{
    public class Vector3
    {
        private double _x, _y, _z;

        public double X { get => _x; set => _x = value; }
        public double Y { get => _y; set => _y = value; }
        public double Z { get => _z; set => _z = value; }

        public double Length
        {
            get => Sqrt(Pow(_x, 2) + Pow(_y, 2) + Pow(_z, 2)); 
        }

        public Vector3(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public static Vector3 operator +(Vector3 v1, Vector3 v2) => new Vector3(v1._x + v2._x, v1._y + v2._y, v1._z + v2._z);
        
        public static Vector3 operator -(Vector3 v1, Vector3 v2) => new Vector3(v1._x - v2._x, v1._y - v2._y, v1._z - v2._z);

        public double GetScalarProductOfVector3(Vector3 v) => _x * v.X + _y * v.Y + _z * v.Z;
        
        public double GetCosCornerBetweenVector3(Vector3 v) => GetScalarProductOfVector3(v) / (Length * v.Length);

        public override string ToString()
        {
            return _x.ToString();
        }
    }
}
