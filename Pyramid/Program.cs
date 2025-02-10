namespace Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loo püramiid tärnidest:");
            Console.WriteLine("--------------------------");
            Console.WriteLine("\n\n");
            Console.WriteLine("Sisesta püramiidi suurus");
            int n;

            n = int.Parse(Console.ReadLine());

            for (var i = 0; i <= n; i++)
            {
                for (var j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }
                for (var j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
