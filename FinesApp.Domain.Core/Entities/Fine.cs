using System;


namespace FinesApp.Domain.Entities
{
    public class Fine
    {
        public int Id { get; set; }
        public DateOnly DateOfPreparation { get; set; }
        public DateTime DateOfViolation { get; set; }
        public virtual TypeOfMiolation Miolation { get; set; }
        public string IssuedBy { get; set; }
        public string Discription { get; set; }
        public decimal MonetaryPenalty { get; set; }
        public bool FinePaid { get; set; }
        public DateOnly DateWhenPaymentDue { get; set; }

        public Fine()
        {

        }

        public Fine(
            DateOnly dateOfPreparation, DateTime dateOfViolation,
            TypeOfMiolation miolation, string issuedBy,
            string discription, decimal monetaryPenalty,
            DateOnly dateWhenPaymentDue, bool finePaid = false)
        {
            DateOfPreparation = dateOfPreparation;
            DateOfViolation = dateOfViolation;
            Miolation = miolation;
            IssuedBy = issuedBy;
            Discription = discription;
            MonetaryPenalty = monetaryPenalty;
            FinePaid = finePaid;
            DateWhenPaymentDue = dateWhenPaymentDue;
        }
    }
}
