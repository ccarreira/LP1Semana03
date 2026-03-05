using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("String: ");
            string text = Console.ReadLine();

            Console.Write("Caráter: ");
            char c = Console.ReadLine()[0];

            string result = text.Replace(c, 'x');

            Console.WriteLine(result);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]); // imprime um carácter por linha
            }

            foreach (char cc in result)
            {
                Console.Write(cc); // imprime um carácter por linha
            }
        }
    }
}