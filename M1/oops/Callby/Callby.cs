using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class SwapNum
    {
       public void swap(ref int n,ref int m)
        {
            int temp;
            temp = m;
            m = n;
            n = temp;
        }
        
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            SwapNum p = new SwapNum();
            p.swap(ref a, ref b);
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}

//call by value- the method changes doesn't get reflected in main method 
//call by reference-the method changes  get reflected in main method 
