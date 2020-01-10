namespace Reservation.Domain.Model.Persons
{
    public class Employee : Person
    {
        public Employee(string firstName, string lastName, string phoneNumber, string email, Degree degree, short age, short experience)
        : base(firstName, lastName, phoneNumber, email)
        {
            if (age < 1)
            {
                throw new DomainException(PersonValidationMessages.InvalidAge);
            }

            if (experience < 0)
            {
                throw new DomainException(PersonValidationMessages.InvalidExperience);
            }

            Degree = degree;
            Age = age;
        }

        public Degree Degree { get; set; }
        public short Age { get; set; }
        public short Experience { get; set; }
    }
}
