using Microsoft.AspNetCore.Identity;
using System;
using System.Net.Mail;

namespace Reservation.Domain.Model.Persons
{
    public class Person : IdentityUser<Guid>
    {

        public Person(string firstName, string lastName, string phoneNumber, string email)
        {
            if (string.IsNullOrWhiteSpace(firstName))
            {
                throw new DomainException(PersonValidationMessages.NullOrWhiteSpaceFirstName);
            }

            if (string.IsNullOrWhiteSpace(lastName))
            {
                throw new DomainException(PersonValidationMessages.NullOrWhiteSpaceLastName);
            }

            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                throw new DomainException(PersonValidationMessages.NullOrWhiteSpacePhoneNumber);
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                throw new DomainException(PersonValidationMessages.NullOrWhiteSpaceEmail);
            }

            if (!IsValidEmail(email))
            {
                throw new DomainException(PersonValidationMessages.InvalidEmail);
            }

            Id = Guid.NewGuid();

            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        private bool IsValidEmail(string email)
        {
            //can use regex !!!
            try
            {
                var m = new MailAddress(email);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
