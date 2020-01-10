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
            void action()
            {
                var employer = new EmployerTestBuilder()
                    .WithFirstName(invalidFirstName)
                    .Build();
            }

            //assert
            var exception = Assert.Throws<DomainException>(action);

            exception.Message
                .Should()
                .BeEquivalentTo(PersonValidationMessages.NullOrWhiteSpaceFirstName.Message);

        }




    }
}
