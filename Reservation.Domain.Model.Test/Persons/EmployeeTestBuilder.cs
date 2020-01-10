using Reservation.Domain.Model.Persons;
using System;

namespace Reservation.Domain.Model.Test.Persons
{
    public class EmployeeTestBuilder
    {
        private const Degree someDegree = Degree.Associate;
        private const short someAge = short.MaxValue;
        private const short someExperience = short.MaxValue;

        private readonly Employee employee;

        public EmployeeTestBuilder()
        {
            employee = new Employee(PersonConstant.SomeFirstName, PersonConstant.SomeLastName,
                PersonConstant.SomePhoneNumber, PersonConstant.SomeEmail, someDegree, someAge, someExperience);
        }

        public Employee Build()
        {
            return new Employee(employee.FirstName, employee.LastName,
                employee.PhoneNumber, employee.Email, employee.Degree,
                employee.Age, employee.Experience);
        }

        public EmployeeTestBuilder WithFirstName(string firstName)
        {
            employee.FirstName = firstName;

            return this;
        }

        public EmployeeTestBuilder WithLastName(string lastName)
        {
            employee.LastName = lastName;

            return this;
        }

        public EmployeeTestBuilder WithPhoneNumber(string phoneNumber)
        {
            employee.PhoneNumber = phoneNumber;

            return this;
        }

        public EmployeeTestBuilder WithEmail(string email)
        {
            employee.Email = email;

            return this;
        }

        public EmployeeTestBuilder WithDegree(Degree degree)
        {
            employee.Degree = degree;

            return this;
        }

        public EmployeeTestBuilder WithAge(short age)
        {
            employee.Age = age;

            return this;
        }

        public EmployeeTestBuilder WithExperience(short experience)
        {
            employee.Experience = experience;

            return this;
        }
    }
}
