using System;
using FinesApp.Domain.Constants;


namespace FinesApp.Domain.Entities
{
    public class RegistrationCertificate
    {
        public string Number { get; set; }
        public string RegisterSign { get; set; }
        public string BrandModel { get; set; }
        public int YearOfIssue { get; set; }
        public CarColors Color { get; set; }
        public string Body_Frame { get; set; }
        public string VehicleType { get; set; }
        public int PermissibleWeight { get; set; }
        public List<string> SpecialMarks { get; set; }
        public DateTime DateOfIssue { get; set; }


        public RegistrationCertificate(
            string number, string registerSign, string brandModel, 
            int yearOfIssue, CarColors color, string body_Frame, 
            string vehicleType, int permissibleWeight, List<string> specialMarks,
            DateTime dateOfIssue)
        {
            Number = number;
            RegisterSign = registerSign;
            BrandModel = brandModel;
            YearOfIssue = yearOfIssue;
            Color = color;
            Body_Frame = body_Frame;
            VehicleType = vehicleType;
            PermissibleWeight = permissibleWeight;
            SpecialMarks = specialMarks;
            DateOfIssue = dateOfIssue;
        }
    }
}
