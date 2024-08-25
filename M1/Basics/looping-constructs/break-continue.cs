using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Loops
    {
        static void Main(string[] args)
        {
                  int num, sum = 0;
        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Enter number");
            num=Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            {
                continue;  //continue with next iteration
            }

            if(num == 0)
            {
                break;
            }
            sum = sum + num;

        }

        Console.WriteLine("sum is {0},",sum);
        }
    }

   

}
