using System;
using System.Collections.Generic;

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
            Name = name;
            Status = status;

            Members = new HashSet<Guid>();
        }

        public Guid Id { get; }
        public string Name { get; set; }
        public Status Status { get; set; }
        public ISet<Guid> Members { get; set; }

        public void AddMember(Guid employeeId)
        {
            Members.Add(employeeId);
        }
    }
}
