using System;

namespace Reservation.Domain.Model.AdHires
{
    public class AdHire
    {
        public AdHire(string title, DateTime expireDate, int capacity)
        {
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new DomainException(AdHireValidationMessage.NullOrWhiteSpaceTitle);
            }

            if (expireDate < DateTime.Now)
            {
                throw new DomainException(AdHireValidationMessage.ExpireDateLessThanCreateDate);
            }

            if (capacity <= 0)
            {
                throw new DomainException(AdHireValidationMessage.ZeroOrMinusCapacity);
            }

            Id = Guid.NewGuid();
            Title = title;
            CreateDate = DateTime.Now; //should get dates from datetime service , it inject into domain ! \
            ExpireDate = expireDate;
            Capacity = capacity;
        }

        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public int Capacity { get; set; }
    }
}
