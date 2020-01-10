using FluentAssertions;
using Reservation.Domain.Model.Persons;
using Xunit;

namespace Reservation.Domain.Model.Test.Persons
{
    public class EmployeeTests
    {
        [Fact]
        public void Constructor_Of_Employee_Should_Set_Value_Of_Degree_Property()
        {
            //arrange
            var someDegree= Degree.Master;

            //act
            void Action()
            {
                var employer = new EmployeeTestBuilder()
                    .WithDegree(someDegree)
                    .Build();
            }

            //assert
            var exception = Assert.Throws<DomainException>(Action);

            exception.Message
                .Should()
                .BeEquivalentTo(PersonValidationMessages.NullOrWhiteSpaceEmail.Message);

        }
    }
}
