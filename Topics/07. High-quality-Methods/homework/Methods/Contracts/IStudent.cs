namespace Methods.Contracts
{
    using System;

    public interface IStudent
    {
        string FirstName { get; set; }

        string LastName { get; set; }

        string PlaceOfBirth { get; set; }

        DateTime DateOfBirth { get; set; }
    }
}
