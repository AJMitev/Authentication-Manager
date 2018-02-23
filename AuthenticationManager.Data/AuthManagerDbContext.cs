namespace AuthenticationManager.Data
{
    using System.Data.Entity;
    using Models;

    public class AuthManagerDbContext : DbContext
    {
        public AuthManagerDbContext() : base("name=AuthManagerConnection")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<AuthManagerDbContext>());
        }

        public IDbSet<Student> Students { get; set; }
        public IDbSet<Teacher> Teachers { get; set; }
        public IDbSet<Course> Courses { get; set; }

    }
}
