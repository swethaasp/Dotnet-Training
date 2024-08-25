using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


 //break- come out of the for loop . no more execution in loop
 //continue - continue to the next iteration. skip current iteration

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


//When the break statement is encountered in a loop, it immediately exits the loop, 
regardless of the loop's condition or remaining iterations.


    //When the continue statement is encountered in a loop (like for, while, or do-while),
    it skips the remaining code in the current iteration and
    immediately moves to the next iteration of the loop.
