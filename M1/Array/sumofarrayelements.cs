Array- Reference type variable 
index also known as subscript

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class Array
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int sum = 0;

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter number");
                arr[i]=Convert.ToInt32(Console.ReadLine());
                sum += arr[i];
            }

          for (int i = 0; i < 10; i++)
           {
              Console.WriteLine("{0} ", arr[i]);
            }


            Console.WriteLine("The sum is {0}" ,sum);
        }
    }
}
