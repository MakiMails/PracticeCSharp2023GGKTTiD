using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Z1
{
    record struct Aeroflot
    {
        private string destination;
        private int flightNumber;
        private string typeAircraft;

        public string Destination
        {
            get { return destination; }
        }
        public int FlightNumber
        {
            get { return flightNumber; }
        }
        public string TypeAircraft
        {
            get { return typeAircraft; }
        }


        public Aeroflot(string destination, int flightNumber, string typeAircraft)
        {
            this.destination = destination;
            this.flightNumber = flightNumber;
            this.typeAircraft = typeAircraft;
        }

        
    }
}
