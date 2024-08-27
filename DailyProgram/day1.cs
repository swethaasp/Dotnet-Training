using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class D1
    {
        static void Main(string[] args)
        {

            //1. program to check odd or even
            
            int number;
            Console.WriteLine("Enter a number");
            number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("{0} is a even number");
            }
            else
            {
                Console.WriteLine("{0} is a odd number");
            }

        }
        

    }
}


 //2.Program to Find the Sum of Array Elements

 int[] arr = new int[5] {1,4,7,0,3};
 int sum = 0;
 foreach(int num in arr)
 {
     sum += num;
 }
 Console.WriteLine(sum);


  //3.Program to Print a Multiplication Table
  int n;
  Console.WriteLine("Enter the number");
  n = int.Parse(Console.ReadLine());
  for(int i = 1; i <= 10; i++)
  {
      Console.WriteLine("{0} * {1} = {2}",n , i ,n * i);
  }


//4.Program to reverse string

string s;
Console.WriteLine("Enter the name");
s = Console.ReadLine();
char[] ch = s.ToCharArray();
Array.Reverse(ch);
string res = new string(ch);
Console.WriteLine(res);

//output
Enter the name
abi
iba

//5.Program to sort array

char[] c = new char[5] { 'u', 't', 'a', 'y', 'x' };
Array.Sort(c);
string res = string.Join(" ", c);
Console.WriteLine(res);

//output
a t u x y


