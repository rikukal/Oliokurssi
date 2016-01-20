using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give Age:");
            string line = Console.ReadLine(); //"50"
            int age = int.Parse(line); // 50

            if (age < 18)
            { Console.WriteLine("You're under-age"); }

            else if (age >= 18 && age <= 65)

            { Console.WriteLine("You're adult"); }

            else {
                Console.WriteLine("You are senior");
            }


            Console.WriteLine("Press enter key to continue..");

            Console.ReadLine();
        }
    }
}
