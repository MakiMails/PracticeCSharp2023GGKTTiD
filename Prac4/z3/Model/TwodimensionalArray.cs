namespace z3.Model
{
    /// <summary>
    /// Класс двухмерный массив строк
    /// </summary>
    public class TwodimensionalArray
    {
        private string[,] _arr;

        /// <value name="CountElem">Количество элемента во всем <c>_arr</c></value>
        public int CountElem
        {
            get { return _arr.Length; }
        }

        /// <summary>
        /// Базовый конструктор класса
        /// </summary>
        /// <param name="sizeI">кол-во строк</param>
        /// <param name="sizeJ">кол-во столбцов</param>
        public TwodimensionalArray(int sizeI, int sizeJ)
        {
            _arr = RandomArr(sizeI, sizeJ);
        }

        /// <summary>
        /// Перегруженный оператор +
        /// </summary>
        /// <param name="a1">Первый объект TwodimensionalArray для сложения</param>
        /// <param name="a2">Второй объект TwodimensionalArray для сложения</param>
        /// <returns>Возращает сумму двух элментов или же вернет null если размеры матриц не совпадают</returns>
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

        /// <summary>
        /// Вывод <c>_arr</c> на консоль
        /// </summary>
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

        /// <summary>
        /// Создание массива строк и заполнением его рандомными значениями
        /// </summary>
        /// <param name="sizeI">кол-во строк</param>
        /// <param name="sizeJ">кол-во столбцов</param>
        /// <returns>Рандомно заполненый массив строк</returns>
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
