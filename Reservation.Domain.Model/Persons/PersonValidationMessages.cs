namespace Reservation.Domain.Model.Persons
{
    public class PersonValidationMessages
    {

        public static ValidationMessage NullOrWhiteSpaceFirstName => new ValidationMessage("FirstName Is Null Or WhiteSpace");
    }
}
