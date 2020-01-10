using System;
using System.Collections.Generic;
using FluentAssertions;
using Reservation.Domain.Model.Projects;
using Xunit;

namespace Reservation.Domain.Model.Test.Projects
{
    public class ProjectTests
    {
        [Fact]
        public void Constructor_Of_Project_Should_Generate_Id()
        {
            //arrange

            //act
            var project = new ProjectTestBuilder()
                .Build();

            //assert
            project.Id
                .Should()
                .NotBeEmpty();
        }

        [Fact]
        public void Constructor_Of_Project_Should_Throw_Exception_When_Name_Is_Null_Or_WhiteSpace()
        {
            //arrange
            var invalidName = string.Empty;

            //act
            void Action()
            {
                var project = new ProjectTestBuilder()
                    .WithName(invalidName)
                    .Build();

            }

            //assert
            var exception = Assert.Throws<DomainException>(Action);

            exception.Message
                .Should()
                .BeEquivalentTo(ProjectValidationMessage.NullOrWhiteSpaceName.Message);
        }

        [Fact]
        public void Constructor_Of_Project_Should_Set_Value_Of_Status()
        {
            //arrange
            const Status expected = Status.Employ;

            //act
            var project = new ProjectTestBuilder()
                .WithStatus(expected)
                .Build();

            //assert
            project.Status
                .Should()
                .BeEquivalentTo(expected);
        }

        [Fact]
        public void Constructor_Of_Project_Should_Initialize_Members_Property()
        {
            //arrange
            var expected = new HashSet<Guid>();

            //act
            var actual = new ProjectTestBuilder()
                .Build();

            //assert
            actual.Members
                .Should()
                .BeEquivalentTo(expected);

        }

        [Fact]
        public void AddMember_Of_Project_Should_Add_Member()
        {
            //arrange 
            var someEmployeeId = Guid.NewGuid();

            var project = new ProjectTestBuilder()
                .Build();

            //act
            project.AddMember(someEmployeeId);

            //assert
            project.Members
                .Should()
                .ContainEquivalentOf(someEmployeeId);
        }
    }
}
