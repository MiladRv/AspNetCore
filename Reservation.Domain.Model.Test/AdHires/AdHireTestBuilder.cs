using Reservation.Domain.Model.AdHires;
using System;

namespace Reservation.Domain.Model.Test.AdHires
{
    public class AdHireTestBuilder
    {
        private const string someTitle = "someTitle";
        private readonly DateTime someExpireDate = DateTime.Now.AddMinutes(10);
        private readonly int someCapacity = int.MaxValue;

        private readonly AdHire built;

        public AdHireTestBuilder()
        {
            built = new AdHire(someTitle, someExpireDate, someCapacity);
        }

        public AdHire Build()
        {
            return new AdHire(built.Title, built.ExpireDate, built.Capacity);
        }

        public AdHireTestBuilder WithTitle(string title)
        {
            built.Title = title;

            return this;
        }

        public AdHireTestBuilder WithExpireDate(DateTime expireDate)
        {
            built.ExpireDate = expireDate;

            return this;
        }

        public AdHireTestBuilder WithCapacity(int capacity)
        {
            built.Capacity = capacity;

            return this;
        }
    }
}
