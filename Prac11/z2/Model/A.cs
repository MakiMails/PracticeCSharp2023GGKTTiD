namespace z2.Model
{
    internal class A
    {
        protected int _a;
        protected int _b;

        public int C 
        { 
            get 
            {
                int a = _a;
                int b = _b;
                do
                {
                    a--;
                    b++;
                } while (a > 0);
                return b;
            } 
        }

        public A()
        {
            _a = 3;
            _b = 5;
        }

    }
}
