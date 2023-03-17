namespace z4.Model
{
    /// <summary>
    /// Вещественная матрица
    /// </summary>
    public class RealMatrix
    {
        private double[,] _arr;


        ///<value name="CountElem">возращает кол-во всех элементов в <c>_arr</c></value>
        public int CountElem
        {
            get { return _arr.Length; }
        }

        /// <summary>
        /// Индексатор
        /// </summary>
        /// <param name="i">Номер строки</param>
        /// <param name="j">Номер столбца</param>
        /// <returns>элемент из матрицы по заданным параметрам</returns>
        public double this[int i, int j]
        {
            get { return _arr[i,j]; }
            set { _arr[i, j] = value; }
        }

        /// <summary>
        /// Базовый конструктор
        /// </summary>
        /// <param name="sizeI">кол-во строк</param>
        /// <param name="sizeJ">кол-во столбцов</param>
        public RealMatrix(int sizeI, int sizeJ)
        {
            _arr = RandomArr(sizeI, sizeJ);
        }


        /// <summary>
        /// Презагрузка оператора + для сложения двух RealMatrix;
        /// Каждый i,j элемент первой RealMatrix будет сложен с каждым i,j  элементов второй RealMatrix
        /// </summary>
        /// <param name="a1">первый объект RealMatrix для сложения</param>
        /// <param name="a2">второй объект RealMatrix для сложения</param>
        /// <returns>сложение двух объектов RealMatrix></returns>
        /// <exception cref="Exception">сробатывает, когда разные размеры матриц</exception>
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

        /// <summary>
        /// Прегрузка оператора + для сложения RealMatrix с числом
        /// Каждый i,j элемент RealMatrix будет сложен с числом
        /// </summary>
        /// <param name="a1">объект RealMatrix для сложения с числом</param>
        /// <param name="num">число для сложения</param>
        /// <returns>объект RealMatrix с которым сложили число</returns>
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

        /// <summary>
        /// Перегрузка оператора - для вычитания RealMatrix с RealMatrix.
        /// Каждый i,j элемент первой RealMatrix будет вычитан из i,j элемент второй RealMatrix
        /// </summary>
        /// <param name="a1">первый объект RealMatrix для вычитания</param>
        /// <param name="a2">второй объект RealMatrix для вычитания</param>
        /// <returns>результат вычитки двух RealMatrix</returns>
        /// <exception cref="Exception"></exception>
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

        /// <summary>
        /// Прегрузка оператора - для вычитания RealMatrix от числа.
        /// Каждый i,j элемент RealMatrix будет вычитан от числа 
        /// </summary>
        /// <param name="a1">объект RealMatrix для вычитания числа</param>
        /// <param name="num">число для вычитания</param>
        /// <returns>объект RealMatrix с которой вычли число</returns>
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

        /// <summary>
        /// Перегрузка оператора ">" для двух объектов RealMatrix
        /// </summary>
        /// <param name="a1">первый объект RealMatrix для сравнения</param>
        /// <param name="a2">второй объект RealMatrix для сравнения</param>
        /// <returns>true/false</returns>
        /// <exception cref="Exception">если разные размеры RealMatrix._arr</exception>
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

        /// <summary>
        /// Перегрузка оператора "<" для двух объектов RealMatrix
        /// </summary>
        /// <param name="a1">первый объект RealMatrix для сравнения</param>
        /// <param name="a2">второй объект RealMatrix для сравнения</param>
        /// <returns>true/false</returns>
        /// <exception cref="Exception">если разные размеры RealMatrix._arr</exception>
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

        /// <summary>
        /// Вывод на консоль RealMatrix._arr
        /// </summary>
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

        /// <summary>
        ///  Создание массива вещественных чисел и заполнением его рандомными значениями
        /// </summary>
        /// <param name="sizeI">кол-во строк</param>
        /// <param name="sizeJ">кол-во столбцов</param>
        /// <returns></returns>
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
