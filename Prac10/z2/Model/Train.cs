using Bogus.DataSets;
using Bogus;

namespace z2.Model
{
    internal class Train:IComparable<Train>
    {
        private string _destination;
        private string _number;
        private TimeOnly _departureTime;

        public string Destination 
        {
            get { return _destination; }  
            set { _destination = value; } 
        }

        public string Number
        {
            get { return _number; }
            set { _number = value; }
        }

        public TimeOnly DepartureTime
        {
            get { return _departureTime; }
            set { _departureTime = value; }
        }

        public Train(string destination, string number, TimeOnly departureTime)
        {
            _destination = destination;
            _number = number;
            _departureTime = departureTime;
        }

        public int CompareTo(Train? train)
        {
            if (train is null) throw new ArgumentException("Некорректное значение параметра");
            return DepartureTime.CompareTo(train.DepartureTime);
        }

        public  static bool operator >(Train t1, Train t2)=> t1._departureTime > t2._departureTime;

        public static bool operator <(Train t1, Train t2)=> t1._departureTime < t2._departureTime;

        public static bool operator ==(Train t1, Train t2) => t1._departureTime == t2._departureTime;
        
        public static bool operator !=(Train t1, Train t2) => t1._departureTime != t2._departureTime;
    }
}
