namespace AuthenticationManager.Models.Contracts
{
    using System.Collections.Generic;

    public interface IStudent: IUser
    {
        ulong StudentId { get; }
         ICollection<Course> Courses { get; set; }

        void EnrollCourse(Course course);
    }
}