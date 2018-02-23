namespace AuthenticationManager.Models
{
    using Abstraction;
    using Contracts;

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
    }
}
