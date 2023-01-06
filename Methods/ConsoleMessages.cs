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
    }
}