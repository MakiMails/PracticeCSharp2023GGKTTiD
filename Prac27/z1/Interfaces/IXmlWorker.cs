using System.Collections.Generic;

namespace z1.Interfaces
{
    internal interface IXmlWorker<T>
    {
        public void Load(string path);
        public void Add(T obj);
        public void Delete(int id);
        public T DindBy(string id);
        public List<T> GetAll();
    }
}
