
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

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == c)
                    Console.Write('x');
                else
                    Console.Write(text[i]);
            }

            Console.WriteLine();
        }
    }
}