using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    
    class hour
    {
        int hr;
        int mnt;
        public hour(int h,int m)
        {
            hr = h;
            mnt = m;
        }
        public static hour operator +  (hour a,hour b)
        {
            hour c = new hour(0, 0);
             c.hr= a.hr + b.hr;
            c.mnt= a.mnt + b.mnt;
            return c;
        }
        public void display()
        {
            Console.WriteLine("{0}  {1}",hr,mnt);
        }
        static void Main(string[] args)
        {
            hour h1 = new hour(3, 40);
            hour h2 = new hour(2, 30);
            hour h3 = h1 + h2;
            h1.display();
            h2.display();
            h3.display();
        }
    }
}
