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
