using Microsoft.AspNetCore.Identity;
using System;

namespace Reservation.Domain.Model.Persons
{
    public class Person : IdentityUser<Guid>
    {
        private object firstName1;

        public Person(string firstName)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new DomainException(PersonValidationMessages.NullOrWhiteSpaceFirstName);
            }


            FirstName = firstName;
        }

        public string FirstName { get; set; }

    }
}
