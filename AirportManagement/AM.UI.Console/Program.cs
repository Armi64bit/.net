
//using AM.Core.Domain;
//using AM.Core.Services;

//Plane plane = new Plane();
//plane.Flights = null;
//plane.Capacity = 0;
//plane.ManufactureDate = DateTime.Now; 
//plane.MyPlaneType = PlaneType.Boing;
//plane.PlaneId = 1;


//Plane plane2 = new Plane(PlaneType.Boing,2,DateTime.Now);
//Plane plane3 = new Plane() 
//{   MyPlaneType = PlaneType.Boing,
//    Capacity = 2,
//    ManufactureDate=DateTime.Now};

////Console.WriteLine(plane);
////Console.WriteLine(plane2);
////Console.WriteLine(plane3);
//Passenger passenger = new Passenger();
//Passenger traveller = new Traveller();
//Passenger staff = new Staff();

//Console.WriteLine(passenger.GetPassengerType());
//Console.WriteLine(traveller.GetPassengerType());
//Console.WriteLine(staff.GetPassengerType());



////passenger.FirstName = "t";
////passenger.LastName = "t";
////Console.WriteLine(passenger.CheckProfile2("t", "t"));
////passenger.EmailAdress = "g";
////Console.WriteLine(passenger.CheckProfile2("t", "t","t"));
//string dateString = "1999-09-07 08:30:00";
//DateTime dateTime = DateTime.Parse(dateString);

//passenger.BirthDate = dateTime;

using AM.Core.Domain;
using AM.Core.Services;

FlightService flightService = new FlightService();
// ... (initialize Flights property with flight data)

string filterType = "Destination";
string filterValue = "Paris";
IEnumerable<Flight> flights = flightService.GetFlights(filterType, filterValue);

foreach (Flight flight in flights)
{
    Console.WriteLine(flight.Departure + " - " + flight.Destination);
}



