using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef_5
{
    class Program
    {
        static void Main(string[] args)
        {

            int nr1;
            int nr2;
            int plus;
            int min;
            int maal;
            int gedeeld;

            Console.WriteLine("write a number 1");
            nr1 = int.Parse(Console.ReadLine());

            Console.WriteLine("write a number 2");
            nr2 = int.Parse(Console.ReadLine());

            plus = nr1 + nr2;
            Console.WriteLine("+ = " + plus);
            min = nr1 - nr2;
            Console.WriteLine("- = " + min);
            maal = nr1 * nr2;
            Console.WriteLine("* = " + maal);
            gedeeld = nr1 / nr2;
            Console.WriteLine("/ = " + gedeeld);

            Console.ReadLine();
        }
    }
}
