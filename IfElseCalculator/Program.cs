namespace IfElseCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert first number and press enter:");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insert calculation type and press enter:");
            var calculateType = Console.ReadLine();

            Console.WriteLine("Insert second number and press enter:");
            double num2 = double.Parse(Console.ReadLine());

            double result = 0;
            if (calculateType == "1")
            {
                result = num1 + num2;
                Console.WriteLine($"{num1} + {num2} = {result}");
            }
            else if (calculateType == "2")
            {
                result = num1 - num2;
                Console.WriteLine($"{num1} - {num2} = {result}");
            }
            else if (calculateType == "3")
            {
                result = num1 * num2;
                Console.WriteLine($"{num1} * {num2} = {result}");
            }
            else if (calculateType == "4")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("CANNOT DIVIDE BY ZERO!");
                    return;
                }
                result = num1 / num2;
                Console.WriteLine($"{num1} / {num2} = {result}");
            }
            else
            {
                Console.WriteLine("ERROR!");
            }
        }
    }
}
