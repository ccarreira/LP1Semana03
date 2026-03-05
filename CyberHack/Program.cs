using System;

namespace CyberHack
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //
            //
            bool hacked = true;
            string tipoSistema = Console.ReadLine();
            string hackTools = Console.ReadLine();

            string[] tools = hackTools.Split();

            //mytipoSistema = Enum.Parse<SystemType>(tipoSistema);


            switch (tipoSistema)
            {
                case "CorporateServer":
                    hacked = true;


                    break;
                case "BankDatabase":

                    break;
                case "SmartCityCore":

                    break;
                case "MilitaryAI":

                    break;


                default:

                    break;
            }


            foreach (string value in tools)
            {
                //Console.WriteLine(value);
            }


            if (tipoSistema == "Military AI")
            {
                hacked = false;
            }
            if (hacked)
            {
                Console.WriteLine("System Hacked");
            }
            else
            {
                Console.WriteLine("System Secure");
            }

        }
    }
}
