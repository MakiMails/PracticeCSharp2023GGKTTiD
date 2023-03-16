namespace z1.Model
{
    internal class MyList<T>
    {
        private T[] arr;

        public T this[int index]
        {
            get
            {
                if (arr != null)
                {
                    if (0 <= index && index < arr.Length)
                    {
                        return arr[index];
                    }
                }
                return default(T);
            }
        }

        public int Length
        {
            get
            {
                if (arr != null)
                {
                    return arr.Length;
                }
                return 0;
            }
        }

        public T[] GetArray()
        {
            if (arr != null)
            {
                return arr;
            }
            return default(T[]);
        }

        public void Add(T obj)
        {
            if (arr != null)
            {
                Array.Resize(ref arr, arr.Length + 1);
            }
            else
            {
                arr = new T[1];
            }
            arr[arr.Length - 1] = obj;
        }
    }
}
