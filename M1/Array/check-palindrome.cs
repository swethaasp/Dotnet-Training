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
                      char[] arr;
            Console.WriteLine("Enter string");
           // Convert the input string to lowercase and then to a character array
           // arr = Console.ReadLine().ToLower().ToCharArray();
            arr=Console.ReadLine().ToCharArray();  //convert string to chaarcater array

            int s = 0;
            int e = arr.Length - 1;
            bool flag = false;
            while (s<= e)
            {
                if (arr[s] != arr[e])
                {
                    flag = true;
                    break;
                }
                s++;
                e--;
            }
                      //while (s <= e)
            //{
            //    if (arr[s] == arr[e])
            //    {
            //      s++;
            //      e--;
            //    }
            //    else{
                //flag=false;
             //break;
            // }

            if (flag == false)
            {
                Console.WriteLine("it is palindrome");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }

        }
    }
}
