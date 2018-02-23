namespace AuthenticationManager.Models
{
    using AuthenticationManager.Models.Abstraction;
    using AuthenticationManager.Models.Contracts;

    public class Teacher : User, IUser, ITeacher
    {
        private Teacher() : base()
        {
            
        }

        public Teacher(string email, string password, string faculty) : base(email, password)
        {
            this.Faculty = faculty;
            this.UserType = TypeOfUser.Teacher;
        }

        public Teacher(string email, string password, string faculty, string firstName, string lastName) : base(email, password, firstName, lastName)
        {
            this.Faculty = faculty;
            this.UserType = TypeOfUser.Teacher;
        }


        public string Faculty { get; set; }

        public virtual ICourse Course { get; set; }

        public override string Welcome()
        {
            return $"Welcome, {this.Email}, you are logged from {this.IpAddress}. Currently you teaching in ${this.Course.Name}.";
        }
    }
}
