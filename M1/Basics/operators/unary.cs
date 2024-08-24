using System;

namespace Basics
{
    class Program1
    {
        static void Main(string[] args)
        {
             int a = 10;
            int b = ++a;  //prefix
            Console.WriteLine($"Prefix ++ ,a={a} ,b={b}");

            int c = 10;
            int d = a++;

            Console.WriteLine($"Postfix ++, c ={c},d ={d}");

            int e = 10;
            int f = --e;

            Console.WriteLine($"The prefix decrement is e={e} ,f={f}");

            int g = 10;
            int h = g--;

            Console.WriteLine("The postfix decrement is g={g},h={h}");

        }
    }
}

In C#, the $ symbol is used to denote an interpolated string.
Interpolated strings allow you to embed expressions inside string literals,
which makes it easy to include variable values or expressions directly within a string.

Output

Prefix ++ ,a=11 ,b=11
Postfix ++, c =10,d =11
The prefix decrement is e=9 ,f=9
The postfix decrement is g={g},h={h}

C:\Users\SWETHAA\source\repos\Solution\Basics\bin\Debug\net8.0\Basics.exe (process 31548) exited with code 0 (0x0).
To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.
Press any key to close this window . . .
