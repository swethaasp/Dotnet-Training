using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class static_fun
    {
        public static int count=0;

        public static void CountFunction()
        {
          count++;
            Console.WriteLine("count func is called by Main{0} times", count);

        }
        static void Main(string[] args)
        {
            for(int var = 0; var < 10; var++)
            {
                static_fun.CountFunction();  //class-name static-function
                //CountFunction();  //this method call will also works
            } 
        }
    }
}
