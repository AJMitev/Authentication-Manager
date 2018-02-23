namespace AuthenticationManager.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    using AuthenticationManager.Common;
    using AuthenticationManager.Models.Abstraction;
    using AuthenticationManager.Models.Contracts;

    public class Student : User, IUser, IStudent
    {
        public Student(string email, string password) : base(email, password)
        {
            this.UserType = TypeOfUser.Student;
            this.StudentId = StudentIdentityGenerator.GenerateStudentNumber();
        }

        public Student(string email, string password, string firstName, string lastName) : base(email, password, firstName, lastName)
        {
            this.UserType = TypeOfUser.Student;
            this.StudentId = StudentIdentityGenerator.GenerateStudentNumber();
        }

        [Column("StudentId", TypeName = "nvarchar(10)")]
        public ulong StudentId { get; private set; }

        public virtual  ICollection<Course> Courses { get; set; }

        public void EnrollCourse(Course course)
        {
            Courses.Add(course);
        }

        public override string Welcome()
        {
            return $"Welcome, {this.Email}, you are logged from {this.IpAddress}. Your Student ID is {this.StudentId}";
        }
    }
}
