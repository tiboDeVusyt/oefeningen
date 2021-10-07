using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string school = "intec brussel klas 2";
            int i = 10;
            Console.WriteLine(school);
            school = school + " in brussel";
            Console.WriteLine(school);
            school = school + " rouppeplein 16";
            Console.WriteLine(school);
            school = "";
            Console.WriteLine(school);

            string moviename = "the lord of the rings";
            Console.WriteLine("position 16 is letter "+ moviename[16]);
            Console.WriteLine("the lord of the rings" + moviename.Length + "chracters");
            Console.WriteLine(moviename.ToUpper());
            Console.WriteLine(moviename.ToLower());
            Console.WriteLine(moviename.Replace("r", "t"));
            Console.WriteLine(moviename.Contains("o"));





            Console.ReadLine();
        }
    }
}
