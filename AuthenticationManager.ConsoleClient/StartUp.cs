namespace AuthenticationManager.ConsoleClient
{
    using System;
    using System.Linq;

    using AuthenticationManager.Common;
    using AuthenticationManager.Data;

    public class StartUp
    {
        private static readonly AuthManagerDbContext DataRepository = new AuthManagerDbContext();

        public static void Main()
        {
            DataHelpers.InitializeData();
            ConsoleManager.PrintWelcomeMessage();

            while (true)
            {
                try
                {
                    ConsoleManager.PrintTypesToChoose();
                    var userType = Console.ReadLine();

                    switch (userType)
                    {
                        case "1": DisplayTeachersLoginMenu(); break;
                        case "2": DisplayStudentsLoginMenu(); break;
                        default: Console.WriteLine(GlobalMessages.InvalidData); break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.InnerException);
                }
            }
        }


        private static void DisplayStudentsLoginMenu()
        {
            Console.WriteLine(GlobalMessages.StudentGreeting);

            Console.Write(GlobalMessages.EmailAddres);
            string email = Console.ReadLine();

            Console.Write(GlobalMessages.Password);
            string password = Console.ReadLine();

            var currentStudent = DataRepository.Students.FirstOrDefault(t => t.Email == email);
            if (currentStudent != null)
            {
                var passwordHash = currentStudent.PasswordHash;

                var veryPassword = PasswordHelper.VerifyPassword(password, passwordHash);

                if (veryPassword)
                {
                    Console.WriteLine(currentStudent.Welcome());
                }
                else
                {
                    Console.WriteLine(GlobalMessages.IdentificationFailed);
                }
            }
        }

        private static void DisplayTeachersLoginMenu()
        {

            Console.WriteLine(GlobalMessages.TeacherGreeting);

            Console.Write(GlobalMessages.EmailAddres);
            string email = Console.ReadLine();

            Console.Write(GlobalMessages.Password);
            string password = Console.ReadLine();

            var currentTeacher = DataRepository.Teachers.FirstOrDefault(t => t.Email == email);

            if (currentTeacher != null)
            {
                var passwordHash = currentTeacher.PasswordHash;

                var veryPassword = PasswordHelper.VerifyPassword(password, passwordHash);

                if (veryPassword)
                {
                    Console.WriteLine(currentTeacher.Welcome());
                }
                else
                {
                    Console.WriteLine(GlobalMessages.IdentificationFailed);
                }
            }
        }
    }
}