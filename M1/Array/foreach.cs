//foreach loops work only with array


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class forEach
    {
      static void Main(string[] args)
        {
            char[] ch;
            Console.WriteLine("Enter String");
            ch = Console.ReadLine().ToCharArray();
            foreach(char c in ch)
              {
                Console.WriteLine("{0} ", c);
            }
        }
    }
}



//alt

            int[] num = { 4, 3, 2, 1, -1, -2, 9, 5 };
            Console.WriteLine("The contents of array");
            foreach(int K in num)
            {
                //Console.Write("{0}\t",K);
                Console.Write($" {K}\t");
            }
        }
    }
}
