namespace AuthenticationManager.ConsoleClient
{
    using System;

    public static class ConsoleManager
    {
        public static void PrintWelcomeMessage()
        {
            string welcomeString = @"++++++++++++=== Welcome to Authentication Manager ===++++++++++++";
            Console.WriteLine(welcomeString);
        }

        public static void PrintTypesToChoose()
        {
            string typeToSelect = "+++== To Identicate as Teacher type 1, for Student type 2 === +++ ";
            Console.WriteLine(typeToSelect);
        }
    }
}
