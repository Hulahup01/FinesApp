using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInesApp.Enteties
{
    internal class Driver: Person
    {
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
