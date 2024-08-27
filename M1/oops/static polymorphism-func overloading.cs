using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
     class Program
    {
        public int sum(int n1,int n2)
        {
            Console.WriteLine("sum with 2 parameter");
            return (n1 + n2);
        }
        public int sum(int n1, int n2,int n3)
        {
            Console.WriteLine("sum with 3 parameter");
            return (n1 + n2 +n3);
        }

        public void sum(int n, string s)
        {
           
        }
        static void Main(string[] args)
        {
            Program p=new Program();
            p.sum(2, 6);
            p.sum(4, 3, 6);
        }
    }
}
