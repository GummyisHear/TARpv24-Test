namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta täht ja vajuta enter");
            var character = Console.ReadLine();

            switch (character)
            {
                case "a":
                    Console.WriteLine("Vokaal a");
                    break;
                case "e":
                    Console.WriteLine("Vokaal e");
                    break;
                case "i":
                    Console.WriteLine("Vokaal i");
                    break;
                default:
                    Console.WriteLine("Ei olevokaal e taishäälik");
                    break;
            }
        }
    }
}
