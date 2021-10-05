using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef3
{
    class Program
    {
        static void Main(string[] args)
        {

            int nr;
            int nr1;
            int nr2;
            Console.WriteLine("write a number");
            nr = int.Parse(Console.ReadLine());


            nr1 = nr * nr;
            nr2 = nr * nr * nr;

            Console.WriteLine(nr1);
            Console.WriteLine(nr2);
            Console.ReadLine();
        }
    }
}
