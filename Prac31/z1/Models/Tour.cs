namespace z1.Models
{
    internal class Tour
    {
        private int _id;
        private string _name;
        private decimal _price;
        private string _info;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public decimal Price
        {
            get => _price;
            set => _price = value;
        }

        public string Info
        {
            get => _info; 
            set => _info = value;
        }

        public Tour(int id, string name, decimal price, string info)
        {
            _id = id;
            _name = name;
            _price = price;
            _info = info;
        }
    }
}
