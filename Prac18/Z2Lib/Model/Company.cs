namespace Z2Lib.Model
{
    public class Company
    {

        private string _name;

        public string Name { get => _name; }

        public Company(string name)
        {
            _name = name;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
