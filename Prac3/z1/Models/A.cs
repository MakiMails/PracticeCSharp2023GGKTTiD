namespace z1.Models
{
    public class A
    {
        private int _a;
        private int _b;

        public A(int a, int b) 
        {
            _a = a;
            _b = b;
        }

        public double GetArithmeticMean()=> (_a + _b) / 2;

        public double GetValueExample()=> Math.Pow(_b,3) + Math.Sqrt(_a);
    }
}
