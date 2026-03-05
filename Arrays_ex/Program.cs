using System;
namespace Arrays_ex
{
    public class Program
    {
        private static void Main(string[] args)
        {
            double[] numbers = new double[] { -1.2, 4, 5, 7 };
            double total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            Console.WriteLine($"A media e {total / numbers.Length}");
        }
    }
}
