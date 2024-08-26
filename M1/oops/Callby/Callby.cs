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
        void display(int n1,int n2,int n3)
        {
            Console.WriteLine("{0} {1} {2}", n1,n2,n3);
        }

        void display1(int n1, int n2, int n3,int n4)
        {
            Console.WriteLine("{0} {1} {2} {3}", n1, n2, n3,n4);
        }

        void display2(params int[] n1)
        {
            foreach (int n in n1)
            {
                Console.WriteLine(n);
             }
        }

        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            SwapNum p = new SwapNum();
            p.swap(ref a, ref b);
            Console.WriteLine("{0} {1}", a, b);
            p.display(4, 7, 2);  //method to display 3  nums
            p.display1(4, 7, 2,1);  //method to display 4  nums
            int[] number = { 10, 202, 30 };
            p.display2(number);
            p.display2(2, 4, 5, 6, 7);  //pass by params
        }
    }
}

//call by value- the method changes doesn't get reflected in main method 
//call by reference-the method changes  get reflected in main method 


