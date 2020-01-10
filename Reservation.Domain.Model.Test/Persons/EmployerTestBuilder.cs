using Reservation.Domain.Model.Persons;
using System;

namespace Reservation.Domain.Model.Test.Persons
{
    public class EmployerTestBuilder
    {
        private const string SomeFirstName = "someFirstName";
        private const string SomeLastName = "someLastName";
        private const string SomePhoneNumber = "09302520691";
        private const string SomeEmail = "lvlilad.l2ivandi@gmail.com";

        private readonly Employer employer;

        public EmployerTestBuilder()
        {
            employer = new Employer(SomeFirstName, SomeLastName, SomePhoneNumber, SomeEmail);
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

        internal object WithDegree(Degree someDegree)
        {
            
        }
    }
}