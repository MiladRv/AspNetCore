using Reservation.Domain.Model.Persons;
using System;

namespace Reservation.Domain.Model.Test.Persons
{
    public class EmployerTestBuilder
    {
       

        private readonly Employer employer;

        public EmployerTestBuilder()
        {
            employer = new Employer(PersonConstant.SomeFirstName, PersonConstant.SomeLastName,
                PersonConstant.SomePhoneNumber, PersonConstant.SomeEmail);
        }

        public Employer Build()
        {
            return new Employer(employer.FirstName, employer.LastName,  employer.PhoneNumber,  employer.Email);
        }

        public EmployerTestBuilder WithFirstName(string firstName)
        {
            employer.FirstName = firstName;

            return this;
        }

        public EmployerTestBuilder WithLastName(string lastName)
        {
            employer.LastName = lastName;

            return this;
        }

        public EmployerTestBuilder WithPhoneNumber(string phoneNumber)
        {
            employer.PhoneNumber = phoneNumber;

            return this;
        }

        public EmployerTestBuilder WithEmail(string email)
        {
            employer.Email = email;

            return this;
        }

    }
}