namespace CalculatorSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Insert first number and press enter:");
            float firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert calculation type by number");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            var calculateType = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert second number and press enter:");
            float secondNumber = int.Parse(Console.ReadLine());

            float result = 0;
            switch (calculateType)
            {
                case 1:
                    result = firstNumber + secondNumber;
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");
                    break;
                case 2:
                    result = firstNumber - secondNumber;
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {result}");
                    break;
                case 3:
                    result = firstNumber * secondNumber;
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {result}");
                    break;
                case 4:
                    result = firstNumber / secondNumber;
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {result}");
                    break;
                default:
                    Console.WriteLine("Are you stupid?");
                    break;
            }
        }

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            nums1 = nums1.Concat(nums2).ToArray();
            nums1 = nums1.Order().ToArray();
            var len = nums1.Length;
            foreach (var n in nums1)
            {
                Console.WriteLine(n);
            }
            var median = len % 2 == 0 ? (nums1[len / 2 - 1] + nums1[len / 2]) / 2.0 : nums1[(int)(len / 2.0)];
            return median;
        }
    }
}
