namespace z3.Model
{
    //Описать класс для работы с двумерным массивом строк.
    //Обеспечить перегрузку операции + для построчного соединения элементов.
    public class TwodimensionalArray
    {
        private string[,] _arr;

        public int CountElem
        {
            get { return _arr.Length; }
        }

        public TwodimensionalArray(int sizeI, int sizeJ)
        {
            _arr = RandomArr(sizeI, sizeJ);
        }

        public static TwodimensionalArray operator +(TwodimensionalArray a1,
            TwodimensionalArray a2)
        {
            if (a1._arr.GetUpperBound(0) == a2._arr.GetUpperBound(0) &&
                a1._arr.GetUpperBound(1) == a2._arr.GetUpperBound(1))
            {
                TwodimensionalArray newArr =
                    new TwodimensionalArray(a1._arr.GetUpperBound(0) + 1, a1._arr.GetUpperBound(1) + 1);
                for (int i = 0; i < a1._arr.GetUpperBound(0) + 1; i++)
                {
                    for (int j = 0; j < a1._arr.GetUpperBound(1) + 1; j++)
                    {
                        newArr._arr[i, j] = a1._arr[i, j] + a2._arr[i, j];
                    }
                }
                return newArr;
            }
            return null;
        }

        public void Write()
        {
            for (int i = 0; i <= _arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j < _arr.GetUpperBound(1) + 1; j++)
                {
                    Console.Write($" {_arr[i,j]}\t");
                }
                Console.WriteLine("");
            }
        }

        private string[,] RandomArr(int sizeI, int sizeJ)
        {
            string[,] newArr = new string[sizeI, sizeJ];
            Random random= new Random();
            for (int i = 0; i < sizeI; i++)
            {
                for (int j = 0; j < sizeJ; j++)
                {
                    newArr[i,j] = random.Next(10).ToString();
                }
            }
            return newArr;
        }
    }
}
