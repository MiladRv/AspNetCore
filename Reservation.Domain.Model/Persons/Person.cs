using Microsoft.AspNetCore.Identity;
using System;

namespace Reservation.Domain.Model.Persons
{
    public class Person : IdentityUser<Guid>
    {

        public Person(string firstName,string lastName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new DomainException(PersonValidationMessages.NullOrWhiteSpaceFirstName);
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                throw new DomainException(PersonValidationMessages.NullOrWhiteSpaceLastName);
            }

            Id = Guid.NewGuid();

            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
