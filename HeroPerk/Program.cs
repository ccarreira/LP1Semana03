using System;
namespace HeroPerk
{
    public class Program

    {
        static void Main(string[] args)
        {
            string s = args.Length > 0 ? args[0] : "";
            Perks p = 0;

            foreach (char c in s)
            {
                switch (c)
                {
                    case 'w': p ^= Perks.WarpShift; break;
                    case 'a': p ^= Perks.Stealth; break;
                    case 's': p ^= Perks.AutoHeal; break;
                    case 'd': p ^= Perks.DoubleJump; break;
                    default: Console.WriteLine("!Unknown perk!"); return;
                }
            }

            if (p == 0) Console.WriteLine("!No perks at all!");
            else Console.WriteLine(p);

            if ((p & (Perks.Stealth | Perks.DoubleJump)) == (Perks.Stealth | Perks.DoubleJump))
                Console.WriteLine("!Silent jumper!");

            if ((p & Perks.AutoHeal) == 0)
                Console.WriteLine("!Not gonna make it!");
        }
    }
}