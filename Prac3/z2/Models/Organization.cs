namespace z2.Models
{
    public abstract class Organization
    {

        private string _name;
        private string _fullNameOwner;
        private decimal _profit;

        public string Name { get { return _name; } set {_name = value; } }
        public string FullNameOwner { get {return _fullNameOwner; } set {_fullNameOwner = value; } }
        public decimal Profit { get {return _profit; } set {_profit = value; } }

        protected Organization(string name, string fullNameOwner, decimal profit)
        {
            _name = name;
            _fullNameOwner = fullNameOwner;
            _profit = profit;
        }
    }
}
