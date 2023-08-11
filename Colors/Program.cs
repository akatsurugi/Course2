namespace Colors
{
    internal class Program
    {
        delegate void PrintStringDelegate(string text);

        static void Main(string[] args)
        {
            PrintStringDelegate printDelegate = PrintGreenColor;
            printDelegate("Green Color");
            printDelegate = PrintOrangeColor;
            printDelegate("Orange Color");
        }

        static void PrintGreenColor(string text)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
        }

        static void PrintOrangeColor(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(text);
        }
    }
}