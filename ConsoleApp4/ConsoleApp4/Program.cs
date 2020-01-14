using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int mase = 100;
            int ugis = 2;
            double kmi = paskaiciuojaKMI(mase, ugis);
            Console.WriteLine(kmi);
            Console.ReadLine();
        }

        static double paskaiciuojaKMI(int mase, int ugis)
        {
            double rezultatas = mase /Math.Pow(ugis, 2);
            return rezultatas;
        }
    }
}
