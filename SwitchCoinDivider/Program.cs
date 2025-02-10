namespace SwitchCoinDivider
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input coins:");
            var coins = int.Parse(Console.ReadLine());

            var fifty = coins / 50;
            coins -= fifty * 50;

            var twenty = coins / 20;
            coins -= twenty * 20;

            var ten = coins / 10;
            coins -= ten * 10;

            var five = coins / 5;
            coins -= five * 5;

            var two = coins / 2;
            coins -= two * 2;

            var one = coins;

            Console.WriteLine("You have: ");
            if (fifty > 0)
                Console.WriteLine($"{fifty} - 50 cent coins");
            if (twenty > 0)
                Console.WriteLine($"{twenty} - 20 cent coins");
            if (ten > 0)
                Console.WriteLine($"{ten} - 10 cent coins");
            if (five > 0)
                Console.WriteLine($"{five} - 5 cent coins");
            if (two > 0)
                Console.WriteLine($"{two} - 2 cent coins");
            if (one > 0)
                Console.WriteLine($"{one} - 1 cent coins");
        }
    }
}
