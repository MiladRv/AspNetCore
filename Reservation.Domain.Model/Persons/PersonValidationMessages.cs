﻿namespace Reservation.Domain.Model.Persons
{
    public class PersonValidationMessages
    {

        public static ValidationMessage NullOrWhiteSpaceFirstName => new ValidationMessage("FirstName Is Null Or WhiteSpace");
        public static ValidationMessage NullOrWhiteSpaceLastName => new ValidationMessage("LastName Is Null Or WhiteSpace");
        public static ValidationMessage NullOrWhiteSpacePhoneNumber => new ValidationMessage("PhoneNumber Is Null Or WhiteSpace");
        public static ValidationMessage NullOrWhiteSpaceEmail => new ValidationMessage("Email Is Null Or WhiteSpace");
        public static ValidationMessage InvalidEmail => new ValidationMessage("Email Is Invalid");

    }
}
