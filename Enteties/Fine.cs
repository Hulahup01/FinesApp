using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInesApp.Enteties
{
    internal class Fine
    {
        public DateTime DateOfPreparation { get; set; }
        public DateTime DateOfViolation { get; set; }
        public TypeOfMiolation Miolation { get; set; }
        public string PlaceOfInfringement { get; set; }
        public string Discription { get; set; }
        public decimal MonetaryPenalty { get; set; }
        public bool FinePaid { get; set; }
        public DateTime DateWhenPaymentDue { get; }

        public Fine(
            DateTime dateOfPreparation, DateTime dateOfViolation,
            TypeOfMiolation miolation, string placeOfInfringement,
            string discription, decimal monetaryPenalty,
            bool finePaid = false)
        {
            DateOfPreparation = dateOfPreparation;
            DateOfViolation = dateOfViolation;
            Miolation = miolation;
            PlaceOfInfringement = placeOfInfringement;
            Discription = discription;
            MonetaryPenalty = monetaryPenalty;
            FinePaid = finePaid;

            DateWhenPaymentDue = DateOfPreparation.AddMonths(1);
        }
    }
}
