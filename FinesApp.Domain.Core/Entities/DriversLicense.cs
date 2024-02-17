using System;
using FinesApp.Domain.Constants;


namespace FinesApp.Domain.Entities
{
    public class DriversLicense
    {
        public int Id { get; set; }
        public string SerialNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public DateOnly DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string IssuedBy { get; set; }
        public DateOnly DateOfIssue { get; set; }
        public DateOnly DateOfExpiration { get; set; }
        public Categories Categories { get; set; }


        public DriversLicense()
        {

        }

        public DriversLicense(
            string serialNumber, string firstName, string lastName, 
            string patronymic, DateOnly dateOfBirth, string placeOfBirth, 
            string issuedBy, DateOnly dateOfIssue, DateOnly dateOfExpiration, Categories categories)
        {
            SerialNumber = serialNumber;
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
            DateOfBirth = dateOfBirth;
            PlaceOfBirth = placeOfBirth;
            IssuedBy = issuedBy;
            DateOfIssue = dateOfIssue;
            DateOfExpiration = dateOfExpiration;
            Categories = categories;
        }
    }
}
