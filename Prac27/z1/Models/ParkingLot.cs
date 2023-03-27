using System.Collections.Generic;

namespace z1.Models
{
    internal class ParkingLot
    {
        List<Auto> _autos = new List<Auto>();

        public List<Auto> Autos
        {
            get => _autos;
            set => _autos = value;
        }

        public Auto this[int i]
        {
            get => _autos[i];
            set => _autos[i] = value;
        }
    }
}
