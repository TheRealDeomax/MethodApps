namespace Methods
{
    internal static class ConsoleMessages
    {
        public static void SayHi()
        {
            Console.WriteLine("Hello World!");
        }
        public static void SayHi(int number)
        {
            Console.WriteLine($"{number} Hello World!");
        }
        public static void SayHi(string something)
        {
            Console.WriteLine(something);
        }

        public static string GetUsersName()
        {
            Console.Write("What is your name:");
            string name = Console.ReadLine();

            return name;

        }

        // Tuple
        public static (string, string) GetFullName()
        {
            Console.Write("What is your first name:");
            string firstName = Console.ReadLine();

            Console.Write("What is your last name:");
            string lastName = Console.ReadLine();

            return (firstName, lastName);


        }
    }
}