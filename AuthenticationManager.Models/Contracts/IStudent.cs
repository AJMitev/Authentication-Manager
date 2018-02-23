namespace AuthenticationManager.Models.Contracts
{
    using System.Collections.Generic;

    public interface IStudent: IUser
    {
        ulong StudentId { get; }
         ICollection<ICourse> Courses { get; set; }

        void EnrollCourse(ICourse course);
    }
}