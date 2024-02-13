using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public enum PlaneType
    {
        Boing, Airbus
    }
    public class Plane
    {
        //private int Capacity;
        //public int GetCapacity () { return Capacity; }
        //public void SetCapacity (int capacity) {  Capacity = capacity; }
        // same thing as the last 3 past lines    
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType MyPlaneType { get; set; }

        public IList<Flight> Flights { get; set; }

        public override string ToString()
        {
            return "Capacity: " + Capacity
                + ";" + "ManufactureDate: " + ManufactureDate
                + ";" + "MyPlaneType: " + MyPlaneType
                + ";" + "FlightFlights " + Flights + ";";
        }
        public Plane(PlaneType pt, int capacity, DateTime date)
        {
            Capacity = capacity;
            ManufactureDate = date;
            MyPlaneType = pt;
        }
        public Plane() { }

    }
}
