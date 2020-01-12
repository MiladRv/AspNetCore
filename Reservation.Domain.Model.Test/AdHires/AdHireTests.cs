using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Reservation.Domain.Model.AdHires;
using Xunit;

namespace Reservation.Domain.Model.Test.AdHires
{
    public class AdHireTests
    {

        [Fact]
        public void Constructor_Of_AdHire_Should_Generate_Id()
        {
            //arrange

            //act
            var actual = new AdHireTestBuilder()
                .Build();

            //assert
            actual.Id
                .Should()
                .NotBeEmpty();

        }

        [Fact]
        public void Constructor_Of_AdHire_Should_Throw_DomainException_When_Title_Is_NullOrWhiteSpace()
        {
            //arrange
            var inValidTitle = string.Empty;

            //act
            void Action()
            {
                var someAdHire = new AdHireTestBuilder()
                    .WithTitle(inValidTitle)
                    .Build();
            }

            //assert
            var exception = Assert.Throws<DomainException>(Action);

            exception
                .Message
                .Should()
                .BeEquivalentTo(AdHireValidationMessage.NullOrWhiteSpaceTitle.Message);
        }

        [Fact]
        public void Constructor_Of_AdHire_Should_Set_CreateDate()
        {
            //arrange
            var expected = DateTime.Now;

            //act
            var actual = new AdHireTestBuilder()
                .Build();

            //assert
            actual
                .CreateDate
                .Should()
                .BeCloseTo(expected);
        }

        [Fact]
        public void Constructor_Of_AdHire_Should_Throw_DomainException_When_ExpireDate_Is_Less_Than_Now()
        {
            //act
            var inValidDate = DateTime.Now.AddMinutes(-1);

            //act
            void Action()
            {
                var someAdHire = new AdHireTestBuilder()
                    .WithExpireDate(inValidDate)
                    .Build();
            }

            //assert
            var exception = Assert.Throws<DomainException>(Action);

            exception
                .Message
                .Should()
                .BeEquivalentTo(AdHireValidationMessage.ExpireDateLessThanCreateDate.Message);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(int.MinValue)]
        public void Constructor_Of_AdHire_Should_Throw_DomainException_When_Capacity_Is_ZeroOrMinus(int capacity)
        {
            //act
           
            //act
            void Action()
            {
                var someAdHire = new AdHireTestBuilder()
                    .WithCapacity(capacity)
                    .Build();
            }

            //assert
            var exception = Assert.Throws<DomainException>(Action);

            exception
                .Message
                .Should()
                .BeEquivalentTo(AdHireValidationMessage.ZeroOrMinusCapacity.Message);
        }
    }
}
