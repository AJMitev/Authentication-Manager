namespace AuthenticationManager.Models.Abstraction
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Common;
    using Contracts;
    public abstract class User : IUser
    {
        protected User()
        {
            
        }
        protected User(string email, string password)
        {
            this.Id = Guid.NewGuid();
            this.Email = email;
            this.PasswordHash = PasswordHelper.CreateHashCode(password);
            this.IpAddress = IPHelper.GetIpAddress();
            this.CreatedOn = DateTime.Now;
            this.UserType = TypeOfUser.Registred;
        }

        protected User(string email, string password, string firstName, string lastName) 
            : this( email, password)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        [Key]
        public Guid Id { get; private set; }
        public string Email { get; private set; }
        public string PasswordHash { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public TypeOfUser UserType { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime CreatedOn { get; private set; }

        public string IpAddress { get; private set; }

        public virtual string Welcome()
        {
            return $"Welcome, {this.Email}, you are logged from {this.IpAddress}";
        }
    }
}
