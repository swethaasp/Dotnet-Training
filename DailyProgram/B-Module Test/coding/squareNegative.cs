using System;
using System.Collections.Generic;

class Solution
{
    static List<int> squareNegative(int N, List<int> A)
    {
        List<int> res=new List<int>();
        for(int i=0;i<N;i++){
            if(A[i]<0){
                res.Add(A[i]*A[i]);
            }
            else{
                res.Add(A[i]);
            }
        }
        return res;
    }
  /*
   static List<int> squareNegative(int N, List<int> A)
    {
        List<int> res=new List<int>();
        for(int i=0;i<N;i++){
           res.Add(A[i]<0 ? A[i]*A[i] : A[i]);
        }
        return res;
    }*/


  /*
  static List<int> squareNegative(int N, List<int> A)
    {
        List<int> res=new List<int>();
        for(int i=0;i<N;i++){
           res.Add(A[i]<0 ? (int)Math.Pow(A[i],2) : A[i]);
        }
        return res;
    }
  */
    static void Main(string[] args)
    {
        // Input: number of elements in the list
        int N = Int32.Parse(Console.ReadLine().Trim());

        // Input: create a list of integers
        List<int> A = new List<int>();
        for (int j = 0; j < N; j++)
        {
            A.Add(Int32.Parse(Console.ReadLine().Trim()));
        }

        // Call the function to square negative elements
        List<int> result = squareNegative(N, A);

        // Output the resulting list
        Console.WriteLine(string.Join(" ", result));
    }
}
