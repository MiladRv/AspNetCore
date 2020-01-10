using FluentAssertions;
using Reservation.Domain.Model.Persons;
using System;
using Xunit;

namespace Reservation.Domain.Model.Test.Persons
{
    public class EmployeeTests
    {
        [Fact]
        public void Constructor_Of_Employee_Should_Generate_Id()
        {
            //arrange
            var expected = Guid.Empty;

            //act
            var employee = new EmployeeTestBuilder()
                .Build();

            //assert
            employee.Id
                .Should()
                .NotBe(expected);
        }

        [Fact]
        public void Constructor_Of_Employee_Should_Throw_Exception_When_FirstName_Is_Null_Or_WhiteSpace()
        {
            //arrange
            var invalidFirstName = string.Empty;

            //act
            void Action()
            {
                var employee = new EmployeeTestBuilder()
                    .WithFirstName(invalidFirstName)
                    .Build();
            }

            //assert
            var exception = Assert.Throws<DomainException>(Action);

            exception.Message
                .Should()
                .BeEquivalentTo(PersonValidationMessages.NullOrWhiteSpaceFirstName.Message);

        }

        [Fact]
        public void Constructor_Of_Employee_Should_Throw_Exception_When_LastName_Is_Null_Or_WhiteSpace()
        {
            //arrange
            var invalidLastName = string.Empty;

            //act
            void Action()
            {
                var employee = new EmployeeTestBuilder()
                    .WithLastName(invalidLastName)
                    .Build();
            }

            //assert
            var exception = Assert.Throws<DomainException>(Action);

            exception.Message
                .Should()
                .BeEquivalentTo(PersonValidationMessages.NullOrWhiteSpaceLastName.Message);

        }

        [Fact]
        public void Constructor_Of_Employee_Should_Throw_Exception_When_PhoneNumber_Is_Null_Or_WhiteSpace()
        {
            //arrange
            var invalidPhoneNumber = string.Empty;

            //act
            void Action()
            {
                var employee = new EmployeeTestBuilder()
                    .WithPhoneNumber(invalidPhoneNumber)
                    .Build();
            }

            //assert
            var exception = Assert.Throws<DomainException>(Action);

            exception.Message
                .Should()
                .BeEquivalentTo(PersonValidationMessages.NullOrWhiteSpacePhoneNumber.Message);

        }

        [Fact]
        public void Constructor_Of_Employee_Should_Throw_Exception_When_Email_Is_Null_Or_WhiteSpace()
        {
            //arrange
            var invalidEmail = string.Empty;

            //act
            void Action()
            {
                var employee = new EmployeeTestBuilder()
                    .WithEmail(invalidEmail)
                    .Build();
            }

            //assert
            var exception = Assert.Throws<DomainException>(Action);

            exception.Message
                .Should()
                .BeEquivalentTo(PersonValidationMessages.NullOrWhiteSpaceEmail.Message);

        }

        [Theory]
        [InlineData("someEmail")]
        [InlineData("someEmail@email. .com")]
        [InlineData("some@Email@email.com")]
        public void Constructor_Of_Employee_Should_Throw_Exception_When_Email_Is_Invalid(string email)
        {
            //arrange

            //act
            void Action()
            {
                var employee = new EmployeeTestBuilder()
                    .WithEmail(email)
                    .Build();
            }

            //assert
            var exception = Assert.Throws<DomainException>(Action);

            exception.Message
                .Should()
                .BeEquivalentTo(PersonValidationMessages.InvalidEmail.Message);

        }

        [Fact]
        public void Constructor_Of_Employee_Should_Set_Value_Of_Degree()
        {
            //arrange
            var expected = Degree.Doctoral;

            //act
            var employee = new EmployeeTestBuilder()
                .WithDegree(expected)
                .Build();

            //assert
            employee.Degree
                .Should()
                .Be(expected);
        }

        [Fact]
        public void Constructor_Of_Employee_Should_Throw_Exception_When_Age_Is_Invalid()
        {
            //arrange
            const short invalidAge = short.MinValue;

            //act
            void Action()
            {
                var employee = new EmployeeTestBuilder()
                    .WithAge(invalidAge)
                    .Build();
            }

            //assert
            var exception = Assert.Throws<DomainException>(Action);

            exception.Message
                .Should()
                .BeEquivalentTo(PersonValidationMessages.InvalidAge.Message);
        }

        [Fact]
        public void Constructor_Of_Employee_Should_Throw_Exception_When_Experience_Is_Invalid()
        {
            //arrange
            const short invalidExperience = short.MinValue;

            //act
            void Action()
            {
                var employee = new EmployeeTestBuilder()
                    .WithExperience(invalidExperience)
                    .Build();
            }

            //assert
            var exception = Assert.Throws<DomainException>(Action);

            exception.Message
                .Should()
                .BeEquivalentTo(PersonValidationMessages.InvalidExperience.Message);
        }
    }
}
