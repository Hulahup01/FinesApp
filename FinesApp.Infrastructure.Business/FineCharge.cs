using System;
using FinesApp.Domain.Entities;
using FinesApp.Services.Interfaces;

namespace FinesApp.Infrastructure.Business
{
    public class FineCharge : ICharge
    {
        public void ChargeOfTheFine(Driver driver, Fine fine)
        {
            driver.Fines.Add(fine);
        }
    }
}
