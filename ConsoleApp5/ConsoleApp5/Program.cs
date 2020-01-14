using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int bilietai10 = 100;
            int bilietai20 = 100;
            int bilietai30 = 100;
            int kiekis;
            int bilietoTipas;
            
            

            Console.WriteLine("Pasirinkite bilietu tipa: [1]10$ [2]20$ [3]30$");
            bilietoTipas = Convert.ToInt32(Console.ReadLine());

            if (bilietoTipas == 1)
            {
                Console.Write("Iveskite bilietu kieki: ");
                kiekis = Convert.ToInt32(Console.ReadLine());
                ParduotiBilietus(ref bilietai10, kiekis);
                Console.WriteLine("Likes bilietu kiekis: {0}", bilietai10);
            }

            else if (bilietoTipas == 2)
            {
                Console.Write("Iveskite bilietu kieki: ");
                kiekis = Convert.ToInt32(Console.ReadLine());
                ParduotiBilietus(ref bilietai20, kiekis);
                Console.WriteLine("Likes bilietu kiekis: {0}", bilietai20);
            }

            else if (bilietoTipas == 3)
            {
                Console.Write("Iveskite bilietu kieki: ");
                kiekis = Convert.ToInt32(Console.ReadLine());
                ParduotiBilietus(ref bilietai30, kiekis);
                Console.WriteLine("Likes bilietu kiekis: {0}", bilietai30);
            }

            else
            {
                Console.WriteLine("Blogas pasirinkimas...");
            }
            
            Console.ReadLine();
            
        }

        private static void ParduotiBilietus(ref int bilietai, int kiekis)
        {
            if (kiekis <= bilietai)
            {
                bilietai = bilietai - kiekis;
            }
            else
            {
                Console.WriteLine("Tiek bilietu neturime...");
            }
            
        }
    }
}
