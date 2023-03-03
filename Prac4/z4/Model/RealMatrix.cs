namespace z4.Model
{
    public class RealMatrix
    {
        private double[,] _arr;

        public int CountElem
        {
            get { return _arr.Length; }
        }

        public double this[int i, int j]
        {
            get { return _arr[i,j]; }
            set { _arr[i, j] = value; }
        }

        public RealMatrix(int sizeI, int sizeJ)
        {
            _arr = RandomArr(sizeI, sizeJ);
        }

        public static RealMatrix operator +(RealMatrix a1,
            RealMatrix a2)
        {
            if (a1._arr.GetUpperBound(0) == a2._arr.GetUpperBound(0) &&
                a1._arr.GetUpperBound(1) == a2._arr.GetUpperBound(1))
            {
                RealMatrix newArr =
                    new RealMatrix(a1._arr.GetUpperBound(0) + 1, a1._arr.GetUpperBound(1) + 1);
                for (int i = 0; i < a1._arr.GetUpperBound(0) + 1; i++)
                {
                    for (int j = 0; j < a1._arr.GetUpperBound(1) + 1; j++)
                    {
                        newArr._arr[i, j] = a1._arr[i, j] + a2._arr[i, j];
                    }
                }
                return newArr;
            }
            throw new Exception("Разные размеры матриц");
        }

        public static RealMatrix operator +(RealMatrix a1,
            double num)
        {
            RealMatrix newArr =
                new RealMatrix(a1._arr.GetUpperBound(0) + 1, a1._arr.GetUpperBound(1) + 1);
            for (int i = 0; i < a1._arr.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < a1._arr.GetUpperBound(1) + 1; j++)
                {
                    newArr._arr[i, j] = a1._arr[i, j] + num;
                }
            }
            return newArr;
        }

        public static RealMatrix operator -(RealMatrix a1,
            RealMatrix a2)
        {
            if (a1._arr.GetUpperBound(0) == a2._arr.GetUpperBound(0) &&
                a1._arr.GetUpperBound(1) == a2._arr.GetUpperBound(1))
            {
                RealMatrix newArr =
                    new RealMatrix(a1._arr.GetUpperBound(0) + 1, a1._arr.GetUpperBound(1) + 1);
                for (int i = 0; i < a1._arr.GetUpperBound(0) + 1; i++)
                {
                    for (int j = 0; j < a1._arr.GetUpperBound(1) + 1; j++)
                    {
                        newArr._arr[i, j] = a1._arr[i, j] - a2._arr[i, j];
                    }
                }
                return newArr;
            }
            throw new Exception("Разные размеры матриц");
        }

        public static RealMatrix operator -(RealMatrix a1,
            double num)
        {
            RealMatrix newArr =
                new RealMatrix(a1._arr.GetUpperBound(0) + 1, a1._arr.GetUpperBound(1) + 1);
            for (int i = 0; i < a1._arr.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < a1._arr.GetUpperBound(1) + 1; j++)
                {
                    newArr._arr[i, j] = a1._arr[i, j] - num;
                }
            }
            return newArr;
        }

        public static bool operator >(RealMatrix a1,
            RealMatrix a2)
        {
            if (a1._arr.GetUpperBound(0) == a2._arr.GetUpperBound(0) &&
                a1._arr.GetUpperBound(1) == a2._arr.GetUpperBound(1))
            {
                for (int i = 0; i < a1._arr.GetUpperBound(0) + 1; i++)
                {
                    for (int j = 0; j < a1._arr.GetUpperBound(1) + 1; j++)
                    {
                        if (a1._arr[i, j] < a2._arr[i, j])
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            throw new Exception("Разные размеры матриц");

        }

        public static bool operator <(RealMatrix a1,
            RealMatrix a2)
        {
            if (a1._arr.GetUpperBound(0) == a2._arr.GetUpperBound(0) &&
                a1._arr.GetUpperBound(1) == a2._arr.GetUpperBound(1))
            {
                for (int i = 0; i < a1._arr.GetUpperBound(0) + 1; i++)
                {
                    for (int j = 0; j < a1._arr.GetUpperBound(1) + 1; j++)
                    {
                        if (a1._arr[i, j] > a2._arr[i, j])
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            throw new Exception("Разные размеры матриц");
        }

        public void Write()
        {
            for (int i = 0; i <= _arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j < _arr.GetUpperBound(1) + 1; j++)
                {
                    Console.Write($" {_arr[i, j]}\t");
                }
                Console.WriteLine("");
            }
        }

        private double[,] RandomArr(int sizeI, int sizeJ)
        {
            double[,] newArr = new double[sizeI, sizeJ];
            Random random = new Random();
            for (int i = 0; i < sizeI; i++)
            {
                for (int j = 0; j < sizeJ; j++)
                {
                    newArr[i, j] = random.Next(10);
                }
            }
            return newArr;
        }
    }
}
