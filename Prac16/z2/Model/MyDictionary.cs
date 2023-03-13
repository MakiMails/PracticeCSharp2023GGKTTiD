namespace z2.Model
{
    internal class MyDictionary<T, V>
    {
        private T[] keys;
        private V[] values;

        public V this[int index]
        {
            get
            {
                if (values != null)
                {
                    if (0 <= index && index < keys.Length)
                    {
                        return values[index];
                    }
                }
                return default(V);
            }
        }

        public int Length
        {
            get
            {
                if (keys != null)
                {
                    return keys.Length;
                }
                return 0;
            }
        }

        public void Add(T key, V value)
        {
            if (keys != null)
            {
                if (Array.IndexOf(keys,key) != -1)
                {
                    return;
                }
                Array.Resize(ref keys, keys.Length + 1);
                Array.Resize(ref values, values.Length + 1);
            }
            else
            {
                keys = new T[1];
                values = new V[1];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
    }
}
