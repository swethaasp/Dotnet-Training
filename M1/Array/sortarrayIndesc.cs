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
          int[] arr = new int[7];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length-1;i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for(int i = 0; i < 7; i++)
            {
                Console.Write("{0} ", arr[i]);
            }

        }
    }
}
