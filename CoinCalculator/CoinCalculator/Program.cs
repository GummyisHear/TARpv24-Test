namespace CoinCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var earthRadiusKm = 6378;
            var coinDiameterMm = 25.75f;

            var earthLengthKm = 2 * earthRadiusKm * MathF.PI;
            var earthLengthMm = 1_000_000 * earthLengthKm;

            var totalCoins = earthLengthMm / coinDiameterMm;

            Console.WriteLine("Coins: " + totalCoins);

        }
    }
}
