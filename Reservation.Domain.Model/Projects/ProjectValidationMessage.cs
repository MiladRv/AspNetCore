namespace Reservation.Domain.Model.Projects
{
    public class ProjectValidationMessage
    {
        public static ValidationMessage NullOrWhiteSpaceName => new ValidationMessage("Name Is Null Or WhiteSpace");

    }
}
