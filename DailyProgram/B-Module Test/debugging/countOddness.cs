using System;
using System.Collections.Generic;

class Solution
{
    // Function to count odd numbers in the list
    static int countOddness(int N, List<int> A)
    {
       int cnt=0;
       A.Sort();
       for(int i=0;i<N;i++){
           if(A[i]%2!=0){  //check for odd values
               if(i==0 || A[i]!=A[i-1]){
                   cnt++;
               }
           }
           
       }
       return cnt;
    }

    static void Main(string[] args)
    {
        // Read the number of elements (N)
        int N = Int32.Parse(Console.ReadLine().Trim());

        // Create a list to hold the elements
        List<int> A = new List<int>();

        // Read N integers into the list
        for (int i = 0; i < N; i++)
        {
            A.Add(Int32.Parse(Console.ReadLine().Trim()));
        }

        // Call countOddness to find the number of odd integers in the list
        int result = countOddness(N, A);

        // Print the result
        Console.WriteLine(result);
    }
}


//1  32  op-0
//2 25  op-65
//5 3 3 8 8 5  op-2
