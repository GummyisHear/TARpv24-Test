namespace IfElseFootSize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter foot size: ");
            var input = Console.ReadLine();
            if (!int.TryParse(input, out var size))
            {
                Console.WriteLine("Enter a number.");
                return;
            }

            switch (size)
            {
                case >= 30 and <= 33:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case >= 34 and <= 38:
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
                case >= 39 and <= 44:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    break;
                case >= 45 and <= 48:
                    Console.Beep();
                    break;
                default:
                    Console.WriteLine("Ei tea mida teha!");
                    break;
            }

            Console.WriteLine("Hello, World!");
        }
    }
}
