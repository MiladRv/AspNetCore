using System;

namespace Reservation.Domain.Model.Projects
{
    public class Project
    {
        public Project(string name, Status status)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new DomainException(ProjectValidationMessage.NullOrWhiteSpaceName);
            }

            Id = Guid.NewGuid();
            Status = status;
        }

        public Guid Id { get; }
        public string Name { get; set; }
        public Status Status { get; set; }
    }
}
