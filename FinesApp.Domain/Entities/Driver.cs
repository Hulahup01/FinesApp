using System;
using System.Collections.ObjectModel;


namespace FinesApp.Domain.Entities
{
    public class Driver: Person
    {
        public int Id { get; set; }
        public DriversLicense License { get; set; }
        public List<RegistrationCertificate> RegistrationCertificates { get; set; }
        public ObservableCollection<Fine> Fines { get; set; }

        public Driver(
            string firstName, string lastName, 
            string patronymic, string gender, 
            DateTime dateOfBirth, string placeOfBirth,
            DriversLicense license, List<RegistrationCertificate> registrationCertificates,
            ObservableCollection<Fine> fines) : 
            base(firstName, lastName, patronymic, gender, dateOfBirth, placeOfBirth)
        {
            License = license;
            RegistrationCertificates = registrationCertificates;
            Fines = fines;
        }
    }
}
