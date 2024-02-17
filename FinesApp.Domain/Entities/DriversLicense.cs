using System;
using FinesApp.Domain.Constants;


namespace FinesApp.Domain.Entities
{
    public class DriversLicense
    {
        public string SerialNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string IssuedBy { get; set; }
        public DateTime DateOfIssue { get; set; }
        public DateTime DateOfExpiration { get; set; }
        public Categories Categories { get; set; }


        public DriversLicense(
            string serialNumber, string firstName, string lastName, 
            string patronymic, DateTime dateOfBirth, string placeOfBirth, 
            string issuedBy, DateTime dateOfIssue, DateTime dateOfExpiration, Categories categories)
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
