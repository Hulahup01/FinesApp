using System;
using FinesApp.Domain.Constants;


namespace FinesApp.Domain.Entities
{
    public class RegistrationCertificate
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string RegisterSign { get; set; }
        public string BrandModel { get; set; }
        public int YearOfIssue { get; set; }
        public CarColors Color { get; set; }
        public string BodyFrame { get; set; }
        public string VehicleType { get; set; }
        public int PermissibleWeight { get; set; }
        public DateOnly DateOfIssue { get; set; }


        public RegistrationCertificate()
        {

        }

        public RegistrationCertificate(
            string number, string registerSign, string brandModel, 
            int yearOfIssue, CarColors color, string bodyFrame, 
            string vehicleType, int permissibleWeight, DateOnly dateOfIssue)
        {
            Number = number;
            RegisterSign = registerSign;
            BrandModel = brandModel;
            YearOfIssue = yearOfIssue;
            Color = color;
            BodyFrame = bodyFrame;
            VehicleType = vehicleType;
            PermissibleWeight = permissibleWeight;
            DateOfIssue = dateOfIssue;
        }
    }
}
