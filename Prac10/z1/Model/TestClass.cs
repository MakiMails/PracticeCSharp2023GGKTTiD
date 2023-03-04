using z1.Interface;

namespace z1.Model
{
    public class TestClass : Ix, Iy, Iz
    {

        private string _str;

        public TestClass(string str)
        {
            _str = str;
        }

        public string IxF0(string str)=> str.Remove(str.Length - 2);
       
        public string IxF1()=> _str.Remove(_str.Length - 2);

        public string F0(string str)=> str.Remove(0, 2);

        public string F1()=> _str.Remove(0, 2);

        string Iz.F0(string str) 
        {
            int indexSpace = str.IndexOf(' ');
            return str.Remove(indexSpace, 1).Insert(indexSpace, "-");
        }

        string Iz.F1()
        {
            int indexSpace = _str.IndexOf(' ');
            return _str.Remove(indexSpace, 1).Insert(indexSpace, "-");
        }


    }
}
