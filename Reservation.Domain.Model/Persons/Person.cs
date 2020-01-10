using Microsoft.AspNetCore.Identity;
using System;

namespace Reservation.Domain.Model.Persons
{
    public class Person : IdentityUser<Guid>
    {

        public Person(string firstName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new DomainException(PersonValidationMessages.NullOrWhiteSpaceFirstName);
            }

            Id = Guid.NewGuid();

            FirstName = firstName;
        }

        public string FirstName { get; set; }

    }
}
