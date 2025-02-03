namespace IfElseColor;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Teha if ja else konsoolirakendus, kus " +
            "kontrollitakse stringi abil värvi vastavust");

        Console.WriteLine("Värvide valikukson: red, blue, green ja white");

        Console.WriteLine("Peab käsitlema juhust, kus vastaja ei sisesta " +
            "eelpool sisestatud värvi");

        Console.WriteLine("\nEnter a color: red, blue, green, white");
        var color = Console.ReadLine();

        if (color == null)
        {
            Error("Entered color was incorrect.");
            return;
        }

        switch (color.ToLower())
        {
            case "red":
                Console.ForegroundColor = ConsoleColor.Red;
                break;
            case "blue":
                Console.ForegroundColor = ConsoleColor.Blue;
                break;
            case "green":
                Console.ForegroundColor = ConsoleColor.Green;
                break;
            case "white":
                Console.ForegroundColor = ConsoleColor.White;
                break;
            default:
                Error("Entered color was incorrect.");
                return;
        }

        Console.WriteLine($"You chose {color}!");
    }

    private static void Error(object text)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Red;
        var now = DateTime.Now;
        var timeString = now.ToLongTimeString() + ":" + now.TimeOfDay.Milliseconds;
        Console.WriteLine(timeString.PadRight(15) + " ERROR".PadRight(10) + text.ToString());
        Console.ResetColor();
    }
}
