using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            double varDouble=10;
            float varfloat = 10.10f;
            decimal vardecimal = 10.10m;

            int getal = 5;

            Console.WriteLine(++getal);//1+5=6
            Console.WriteLine(getal++);//6+1=7 toont 6 want getal++ toont het getal voor de ++

            Console.WriteLine(getal);//=7

            Console.ReadLine();
        }
    }
}
