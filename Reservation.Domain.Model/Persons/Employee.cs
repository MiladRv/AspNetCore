namespace Reservation.Domain.Model.Persons
{
    public class Employee : Person
    {
        public Employee(string firstName, string lastName, string phoneNumber, string email, Degree degree)
        : base(firstName, lastName, phoneNumber, email)
        {
            Degree = degree;
        }

        public Degree Degree { get; set; }
    }
}
