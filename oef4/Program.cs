using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef4
{
    class Program
    {
        static void Main(string[] args)
        {
            double straal;
            double omtrek;
            double opervlak;
            double pi = 3.14;

            Console.WriteLine("schrijf een straal");
            straal = int.Parse(Console.ReadLine());

            omtrek = (straal * pi)*2;
            Console.WriteLine("de diameter = " + omtrek);

            opervlak = straal * straal * pi;


            Console.WriteLine("de oppervlak = "+ opervlak);

            Console.ReadLine();
        }
    }
}
