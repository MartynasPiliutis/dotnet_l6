using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string pradineEilute = "Karabasas";
            string eilute = sukuriaEilute(pradineEilute);
            Console.WriteLine(eilute);
            Console.ReadLine();
        }

        static string sukuriaEilute(string pradineEilute)
        {
            int ilgis = pradineEilute.Length;
            string sharpuEilute = "";
            for (int i = 0; i < ilgis; i++)
            {
                sharpuEilute += "#";
            }
            return sharpuEilute;
        }

    }
}
