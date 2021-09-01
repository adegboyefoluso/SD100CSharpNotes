using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Person
    {
        public Person() { }
        public Person(string firstName, string lastName, DateTime dob, string socSec, int credit)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dob;
            SocialSecurity = socSec;
            CreditScore = credit;
        }

        public string FirstName { get; set; }

        // Backing field
        private string _lastName;
        public string LastName 
        {   // Return _lastName field's first letter only
            get { return _lastName[0].ToString(); } 
            // Assign the value to _lastName
            set { _lastName = value; } 
        }
        // Readonly property, no set
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public DateTime DateOfBirth { get; set; }
        // XXX-XX-XXXX
        private string _socialSecurity;
        public string SocialSecurity
        {
            // Split makes the string into an array, splitting at that character
            get { return _socialSecurity.Split('-')[2]; }
            set { _socialSecurity = value; }
        }
        public int CreditScore { get; set; }
        public Vehicle Transport { get; set; }

    }
}
