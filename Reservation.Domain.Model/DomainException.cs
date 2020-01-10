using System;

namespace Reservation.Domain.Model
{
    public class DomainException : Exception
    {
        public DomainException(ValidationMessage validationMessage)
            : base(validationMessage.Message)
        {

        }

    }
}
