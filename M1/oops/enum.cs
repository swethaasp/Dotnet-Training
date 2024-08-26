using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
     class Enumemo
    {
        enum days { mon ,tue ,wed, thurs=10, fri,sat,sun}
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("{0}", days.mon);
            Console.WriteLine("{0}", days.tue);
            Console.WriteLine("{0}", days.wed);
            Console.WriteLine("{0}", days.thurs);
            Console.WriteLine("{0}", days.fri);
            Console.WriteLine("{0}", days.sat);
            Console.WriteLine("{0}", days.sun);
            */

            Console.WriteLine("{0}", (int)days.mon);
            Console.WriteLine("{0}", (int)days.tue);
            Console.WriteLine("{0}", (int)days.wed);
            Console.WriteLine("{0}", (int)days.thurs);
            Console.WriteLine("{0}", (int)days.fri);
            Console.WriteLine("{0}",(int) days.sat);
            Console.WriteLine("{0}",(int) days.sun);

            //default values will be 0,1,2,3,4,5,6 when u dont assign any values to enum variables
            //when u assign mon=10, it will print continuous values for all other variables after that .
            //when u assign thurs=10, it will print continuous values for all other variables after that . for mon =0,tues=1,wed=2

        }
    }
}
