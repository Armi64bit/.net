using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        public string PassportNumber { get; set; }
        public string EmailAdress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelNumber { get; set; }
        public int Age { get
            {  
                    if (BirthDate == null)
                    {
                        return 0;
                    }
                    var today = DateTime.Today;
                    int age = today.Year - BirthDate.Year;
                    if (BirthDate.AddYears(age) > today)
                    {
                        age--;
                    }
                    return age;
                }
            }

        IList<Flight> Flights { get; set; }
        public override string ToString()
        {
            return "PassportNumber: " + PassportNumber
                + ";" + "BirthDate: " + BirthDate
                + ";" + "EmailAdress: " + EmailAdress
                + ";" + "FirstName: " + FirstName
                + ";" + "LastName: " + LastName
                + ";" + "TelNumber: " + TelNumber
                + ";" + "Flights " + Flights + ";";
        }
        public bool CheckProfile (string nom,string prenom) {
            if (FirstName==nom && LastName==prenom)
                return true;
            return false;   }
        public  bool CheckProfile (string email , string nom, string prenom)
        {
            if (FirstName == nom && LastName == prenom && EmailAdress == email)
                return true;
            return false;
        }
        public bool CheckProfile2(string nom, string prenom, string email = null)
        {
            if (email == null)
            {
                return FirstName == nom && LastName == prenom;
            }
            else
            {
                return FirstName == nom && LastName == prenom && EmailAdress == email;
            }
        }

        public virtual string GetPassengerType()
        {
            return "I am a passenger";
        }


    }
}
