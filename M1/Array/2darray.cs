using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class forEach
    {
        static void Main(string[] args)
        {



int[,] arr = new int[3, 3];
 for(int i = 0; i < 3; i++)
 {
     for(int j = 0; j < 3; j++)
     {
         Console.WriteLine("Enter the number");
         arr[i, j] = Convert.ToInt32(Console.ReadLine());
     }
 }

 for(int i = 0; i < 3; i++)
 {
     for(int j = 0; j < 3; j++)
     {
         Console.Write("{0} ",arr[i,j]);
     }
     Console.WriteLine();
 }
        }
    }
}
