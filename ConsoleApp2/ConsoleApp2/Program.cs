using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeat = 10;
            string vardas = "Name";

            isvedaVardaKonsole(repeat, vardas);
            Console.ReadLine();
        }

        private static void isvedaVardaKonsole(int repeat, string vardas)
        {
            for (int i = 0; i < repeat; i++)
            {
                Console.WriteLine(vardas);
            }
        }
    }
}
