using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInesApp.Enteties
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }

        public int Age 
        {
            get
            {
                return DateTime.Now.Year - DateOfBirth.Year;
            }
        }

        public Person(
            string firstName, string lastName,
            string patronymic, string gender, 
            DateTime dateOfBirth, string placeOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            PlaceOfBirth = placeOfBirth;
        }
    }
}
