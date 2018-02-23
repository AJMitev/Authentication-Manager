namespace AuthenticationManager.Data.Migrations
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using AuthenticationManager.Models;

    public sealed class Configuration : DbMigrationsConfiguration<AuthManagerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = false;
            ContextKey = "AuthenticationManager.Data.AuthManagerDbContext";
        }

        protected override void Seed(AuthManagerDbContext context)
        {

            PopulateCourses(context);
            PopulateTeachers(context);
            PopulateStudents(context);
        }

        private void PopulateStudents(AuthManagerDbContext context)
        {

            if (context.Students.Any())
            {
                return;
            }

            for (int i = 0; i < 10; i++)
            {
                var student = new Student($"student{i}@mail.eu", $"password{i}");
                context.Students.Add(student);
            }

            context.SaveChanges();
        }

        private void PopulateTeachers(AuthManagerDbContext context)
        {

            if (context.Teachers.Any())
            {
                return;
            }

            var teacher = new Teacher("teacher@academy.com", "teacher123", "Technology");

            context.Teachers.Add(teacher);
            context.SaveChanges();
        }

        private void PopulateCourses(AuthManagerDbContext context)
        {

            if (context.Courses.Any())
            {
                return;
            }
            var courseList = new List<Course>
                {
                    new Course("Programming Basics"),
                    new Course("CSharp Advanced"),
                    new Course("OOP Basics"),
                    new Course("OOP Advanced")
                };

            foreach (var course in courseList)
            {
                context.Courses.Add(course);
            }

            context.SaveChanges();
        }
    }
}