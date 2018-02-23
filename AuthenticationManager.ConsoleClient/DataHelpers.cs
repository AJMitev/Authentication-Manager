namespace AuthenticationManager.ConsoleClient
{
    using System.Data.Entity;

    using AuthenticationManager.Data;
    using AuthenticationManager.Data.Migrations;

    public static class DataHelpers
    {
        public static void InitializeData()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<AuthManagerDbContext>());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AuthManagerDbContext, Configuration>());
        }
    }
}