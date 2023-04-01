namespace z1.Models
{
    internal class Tourist
    {
        private int _id;
        private string _surname;
        private string _name;
        private string _midlename;
        private TouristInfo _touristInfo;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Surname
        {
            get => _surname;
            set => _surname = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Midlename
        {
            get => _midlename;
            set => _midlename = value;
        }

        public TouristInfo Info
        {
            get => _touristInfo;
            set => _touristInfo = value;   
        }
        
        public Tourist(int id, string surname, string name,
            string midlename, TouristInfo info)
        {
            _id = id;
            _surname = surname;
            _name = name;
            _midlename = midlename;
            _touristInfo = info;
        }
    }
}
