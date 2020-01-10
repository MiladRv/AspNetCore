using System;
using FluentAssertions;
using Reservation.Domain.Model.Persons;
using Xunit;

namespace Reservation.Domain.Model.Test.Persons
{
    public class EmployerTests
    {

        [Fact]
        public void Constructor_Of_Employer_Should_Generate_Id()
        {
            //arrange
            var expected = Guid.Empty;

            //act
            var employer = new EmployerTestBuilder()
                .Build();

            //assert
            employer.Id
                .Should()
                .NotBe(expected);
        }

        [Fact]
        public void Constructor_Of_Employer_Should_Throw_Exception_When_FirstName_Is_Null_Or_WhiteSpace()
        {
            //arrange
            var invalidFirstName = string.Empty;

            //act
            void Action()
            {
                var employer = new EmployerTestBuilder()
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
        public void Constructor_Of_Employer_Should_Throw_Exception_When_LastName_Is_Null_Or_WhiteSpace()
        {
            //arrange
            var invalidLastName = string.Empty;

            //act
            void Action()
            {
                var employer = new EmployerTestBuilder()
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
        public void Constructor_Of_Employer_Should_Throw_Exception_When_PhoneNumber_Is_Null_Or_WhiteSpace()
        {
            //arrange
            var invalidPhoneNumber = string.Empty;

            //act
            void Action()
            {
                var employer = new EmployerTestBuilder()
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
        public void Constructor_Of_Employer_Should_Throw_Exception_When_Email_Is_Null_Or_WhiteSpace()
        {
            //arrange
            var invalidEmail = string.Empty;

            //act
            void Action()
            {
                var employer = new EmployerTestBuilder()
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
        public void Constructor_Of_Employer_Should_Throw_Exception_When_Email_Is_Invalid(string email)
        {
            //arrange

            //act
            void Action()
            {
                var employer = new EmployerTestBuilder()
                    .WithEmail(email)
                    .Build();
            }

            //assert
            var exception = Assert.Throws<DomainException>(Action);

            exception.Message
                .Should()
                .BeEquivalentTo(PersonValidationMessages.InvalidEmail.Message);

        }

      
    }
}
