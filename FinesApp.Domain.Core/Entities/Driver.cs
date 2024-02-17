using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;


namespace FinesApp.Domain.Entities
{
    public class Driver: Person
    {
        public int Id { get; set; }
        public virtual DriversLicense License { get; set; }
        public virtual List<RegistrationCertificate> RegistrationCertificates { get; set; }
        public virtual List<Fine> Fines { get; set; }

        public Driver()
        {

        }

        public Driver(
            string firstName, string lastName, 
            string patronymic, string gender, 
            DateOnly dateOfBirth, string placeOfBirth,
            DriversLicense license, List<RegistrationCertificate> registrationCertificates,
            List<Fine> fines) : 
            base(firstName, lastName, patronymic, gender, dateOfBirth, placeOfBirth)
        {
            License = license;
            RegistrationCertificates = registrationCertificates;
            Fines = fines;
        }
    }
}
