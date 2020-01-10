using Reservation.Domain.Model.Persons;

namespace Reservation.Domain.Model.Test.Persons
{
    public class EmployerTestBuilder
    {
        private const string SomeFirstName = "someFirstName";
        private const string SomeLastName = "someLastName";

        private readonly Employer employer;

        public EmployerTestBuilder()
        {
            employer = new Employer(SomeFirstName,SomeLastName);
        }

        public Employer Build()
        {
            return  new Employer(employer.FirstName,employer.LastName);
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
    }
}