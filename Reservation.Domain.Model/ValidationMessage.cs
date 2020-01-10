namespace Reservation.Domain.Model
{
    public class ValidationMessage
    {
        public ValidationMessage(string message)
        {
            Message = message;
        }

        public string Message { get; private set; }
    }
}
