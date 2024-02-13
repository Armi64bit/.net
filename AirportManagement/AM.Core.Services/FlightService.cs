using AM.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Services
{
    public class FlightService : IFlightService
    {
        public IList<Flight> Flights { get; set; }

        public IList<DateTime> GetFlightDates(string destination)
        {
            return (IList<DateTime>)Flights.Where(f => f.Destination == destination).Select(f => f.FlightDate).Distinct();
        }
        public IList<Flight> GetFlights(string filterType, string filterValue)
        {
            if (Flights == null)
            {
                throw new InvalidOperationException("Flight list is not initialized.");
            }
            PropertyInfo property = typeof(Flight).GetProperty(filterType);
            if (property == null)
            {
                throw new ArgumentException($"Propriété inconnue : {filterType}");
            }
            return Flights.Where(f => property.GetValue(f).ToString() == filterValue).ToList();
        }
    }
    
        
}
