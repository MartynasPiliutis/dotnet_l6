using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string vardas = "Martynas";
            isvedaKonsolenVarda(vardas);
            Console.ReadLine();
        }

        private static void isvedaKonsolenVarda(string vardas)
        {
            Console.WriteLine(vardas);
        }
    }

}
