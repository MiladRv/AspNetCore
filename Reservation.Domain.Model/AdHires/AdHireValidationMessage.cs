namespace Reservation.Domain.Model.AdHires
{
    public  class AdHireValidationMessage
    {
        public static ValidationMessage NullOrWhiteSpaceTitle => new ValidationMessage("Title Is Null Or WhiteSpace");

        public static ValidationMessage ExpireDateLessThanCreateDate => new ValidationMessage("expireDate is less than createDate");

        public static ValidationMessage ZeroOrMinusCapacity => new ValidationMessage("capacity is zero or minus");
    }
}
