using System;
using System.Collections.Generic;

public class Solution
{
    public static List<int> ReverseSecond(int N, List<int> A)
    {
        if(N<=1){
            return A;
        }
        List<int> res =new List<int>(A);
        List<int> sublist = new List<int>();
        
        for(int i=1;i<N;i+=2){
            sublist.Add(A[i]);
        }
        sublist.Reverse();
        
        int index=0;
        for(int i=1;i<N;i+=2){
           res[i]=sublist[index++]; 
        }
        return res;
    }

    public static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine().Trim());
        List<int> A = new List<int>();

        for (int j = 0; j < N; j++)
        {
            A.Add(int.Parse(Console.ReadLine().Trim()));
        }

        List<int> result = ReverseSecond(N, A);

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}
