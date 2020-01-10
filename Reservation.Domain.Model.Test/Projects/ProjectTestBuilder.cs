using Reservation.Domain.Model.Projects;

namespace Reservation.Domain.Model.Test.Projects
{
    public class ProjectTestBuilder
    {
        private const string someName = "someName";
        private const Status someStatus = Status.Employ;

        private readonly Project project;

        public ProjectTestBuilder()
        {
            project = new Project(someName, someStatus);
        }

        public Project Build()
        {
            return new Project(project.Name, project.Status);
        }

        public ProjectTestBuilder WithName(string name)
        {
            project.Name = name;

            return this;
        }

        public ProjectTestBuilder WithStatus(Status status)
        {
            project.Status = status;

            return this;
        }
    }
}