using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace z1.Models
{
    internal class Auto : INotifyPropertyChanged
    {
        private int _id;
        private string _stamp;
        private int _yearRelease;
        private int _parkingRentalPeriod;

        public event PropertyChangedEventHandler? PropertyChanged;

        public int ID 
        { 
            get => _id;
            set 
            {
                _id = value;
                OnPropertyChanged("ID");
            }
        }
        public string Stamp 
        { 
            get => _stamp;
            set
            {
                _stamp = value;
                OnPropertyChanged("Stamp");
            }
        }
        public int YearRelease 
        { 
            get => _yearRelease;
            set
            {
                _yearRelease = value;
                OnPropertyChanged("YearRelease");
            }
        }
        public int ParkingRentalPeriod 
        { 
            get => _parkingRentalPeriod;
            set
            {
                _parkingRentalPeriod = value;
                OnPropertyChanged("ParkingRentalPeriod");
            }
        }

        public Auto(int id, string stamp,
            int yearRelease, int parkingRentalPeriod)
        {
            _id = id;
            _stamp = stamp;
            _yearRelease = yearRelease;
            _parkingRentalPeriod = parkingRentalPeriod;
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public override string ToString()
        {
            return $"===============================================================\n" +
                $"ID: {_id}\n"+
                $"Марка: {_stamp}\n" +
                $"Год выпуска: {_yearRelease}\n" +
                $"Срок аренды стоянки(дни): {_parkingRentalPeriod}\n" +
                $"===============================================================\n" +
                $"\n";
        }
    }
}
