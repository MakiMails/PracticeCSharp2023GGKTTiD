namespace z1.Models
{
    internal class TouristInfo
    {
        private string _passportSeries;
        private string _city;
        private string _state;
        private string _numPhone;
        private int _index;

        public string PassportSeries
        {
            get => _passportSeries;
            set => _passportSeries = value;
        }

        public string City
        {
            get => _city;
            set => _city = value;
        }

        public string State
        {
            get => _state;
            set => _state = value;
        }

        public string NumPhone
        {
            get => _numPhone;
            set => _numPhone = value;
        }

        public int Index
        {
            get => _index;
            set => _index = value;
        }

        public TouristInfo(string passportSeries, string city, string state,
            string numPhone, int index)
        {
            _passportSeries = passportSeries;
            _city = city;
            _state = state;
            _numPhone = numPhone;
            _index = index;
        }
    }
}