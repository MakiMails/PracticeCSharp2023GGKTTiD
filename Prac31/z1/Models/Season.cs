namespace z1.Models
{
    internal class Season
    {
        private int _codeTour;
        private DateOnly _dateStart;
        private DateOnly _dateEnd;
        private bool _isClose;
        private int _countPlaces;

        public int CodeTour
        {
            get => _codeTour;
            set => _codeTour = value;
        }

        public DateOnly DateStart
        {
            get => _dateStart;
            set => _dateStart = value;
        }

        public DateOnly DateEnd
        {
            get => _dateEnd;
            set => _dateEnd = value;
        }

        public bool IsClose
        {
            get => _isClose;
            set => _isClose = value;
        }

        public Season(int codeTour, DateOnly dateStart,
            DateOnly dateEnd, bool isClose, int countPlaces)
        {
            _codeTour = codeTour;
            _dateStart = dateStart;
            _dateEnd = dateEnd;
            _isClose = isClose;
            _countPlaces = countPlaces;
        }
    }
}
