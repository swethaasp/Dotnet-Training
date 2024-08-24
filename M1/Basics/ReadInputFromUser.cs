using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Basics
{
    class Program1
    {
        public static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;

            Console.WriteLine("The sum of num1 and num2 is :{0}", sum);





        }
    }
}
