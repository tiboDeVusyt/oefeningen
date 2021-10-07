using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef6
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal kmTraveld;
            decimal km1;
            decimal km2;
            decimal fuelRefill;
            decimal fueltot;
            decimal fuel1;
            decimal verbruik;


            Console.WriteLine("kilometer traveld start");
            km1 = int.Parse(Console.ReadLine());


            Console.WriteLine("kilometer traveld end");
            km2 = int.Parse(Console.ReadLine());


            Console.WriteLine("fuel at the start");
            fueltot = int.Parse(Console.ReadLine());


            Console.WriteLine("write your remaining fuel after the rit");
            fuel1 = int.Parse(Console.ReadLine());

            kmTraveld = km2 - km1;
            fuelRefill = fueltot - fuel1;
            verbruik = fuelRefill / kmTraveld;
           
            Console.WriteLine("you traveld " + kmTraveld + "km");
            Console.WriteLine("you need to refill " + fuelRefill + "L");

            Console.WriteLine("you used " + verbruik*100 + "L/km100");

            Console.ReadLine();




        }
    }
}
