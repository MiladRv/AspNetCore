using Reservation.Domain.Model.Persons;

namespace Reservation.Domain.Model.Test.Persons
{
    public class EmployerTestBuilder
    {
        private const string SomeFirstName = "someFirstName";

        private readonly Employer employer;

        public EmployerTestBuilder()
        {
            employer = new Employer(SomeFirstName);
        }

        public Employer Build()
        {
            return  new Employer(employer.FirstName);
        }

        public EmployerTestBuilder WithFirstName(string firstName)
        {
            employer.FirstName = firstName;

            return this;
        }
    }
}