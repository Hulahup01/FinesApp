using System;
using FinesApp.Domain.Entities;

namespace FinesApp.Services.Interfaces
{
    public interface ICharge
    {
        void ChargeOfTheFine(Driver driver, Fine fine);
    }
}
