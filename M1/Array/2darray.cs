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



           // 2d array with rowsum
                          int[,] arr = new int[3, 3];
            int totsum = 0;
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Enter the number");
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                int rowsum = 0;
                for (int j = 0; j < 3; j++)
                {
                    
                    Console.Write("{0} ", arr[i, j]);
                    rowsum += arr[i, j];

                }
                totsum+= rowsum;
                Console.WriteLine("Row sum is : {0}", rowsum);
                Console.WriteLine();
            }
            
            Console.WriteLine("The total sum is {0}",totsum);
        }
    }
}




// add arr1[0,0] and arr2[0,0] .store res in arr3[0,0]
            int[,] arr1 = new int[3, 3];
            int[,] arr2 = new int[3, 3];
            int[,] arr3 = new int[3, 3];

            //get arr1 elements from user
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //get arr2 elements from user
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //do sum
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    arr3[i, j] = arr1[i, j] + arr2[i, j];
                }
            }

            //print arr3
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr3[i, j]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}




