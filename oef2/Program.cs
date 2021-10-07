using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nr1;
            int nr;
            int nr2;
            Console.WriteLine("write a number");
            nr1 = int.Parse(Console.ReadLine());
            nr = nr1 + 15;
            nr = nr * 2;
            nr = nr - 4;
            nr = nr / 2;
            Console.WriteLine(nr);

            nr2 = nr1 - nr;

            Console.WriteLine("het verschil= " + -nr2);

            Console.ReadLine();
        }
    }
}
