namespace AuthenticationManager.Models.Contracts
{
    using System;

    public interface IUser
    {
       Guid Id { get; }
        string Email { get; }
        string PasswordHash { get; }
        string FirstName { get; }
        string LastName { get; }
        TypeOfUser UserType { get; }
        DateTime CreatedOn { get; }
        string IpAddress { get; }

        string Welcome();
    }
}