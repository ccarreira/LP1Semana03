using System;

namespace EnumExClass
{
    public class Program
    {
        private static void Main(string[] args)
        {
            WOW myClass;
            myClass = 0;

            foreach (string arg in args)
            {
                myClass = Enum.Parse<WOW>(arg);
            }

            if (myClass == WOW.Warrior)
            {
                Console.WriteLine("Fight!");
            }

            if (myClass == WOW.Mage)
            {
                Console.WriteLine("Conjure!");
            }
        }
    }
}
