using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Basics
{
    class Program1
    {
        static void Main(string[] args)
        {
                      int a, b, c;
            Console.WriteLine("Enter first number");
            a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter first number");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter first number");
            c = Convert.ToInt32(Console.ReadLine());

            if(a>b && a > c)
            {
                //Console.WriteLine($"a: {a} is largest ");
                Console.WriteLine("{0} is a largest ", a);
            }
            else if(b>a && b > c)
            {
                Console.WriteLine($"b : {b} is a largest");
            }
            else if(c>a && c > b)
            {
                Console.WriteLine($"c: {c} is a largest");
            }
            else
            {
                Console.WriteLine("All Three numbers are equal ");
            }

        }
    }
}
