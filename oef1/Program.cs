using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef1
{
    class Program
    {
        static void Main(string[] args)
        {

            int jaar;
            int age;

            Console.WriteLine("write your name");
            string name = Console.ReadLine();



            Console.WriteLine("schrijf je geboortejaar");
            jaar = int.Parse(Console.ReadLine());

            age = 2021 - jaar;
            Console.WriteLine("your age is " + age);
            Console.WriteLine("yuur name is " + name);



        }
    }
}                  