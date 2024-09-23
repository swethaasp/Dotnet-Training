using System;
using System.Collections.Generic;
using System.Linq;

public class MainClass
{
    public static void Main(string[] args)
    {
        // Input the number of test cases
        int t = int.Parse(Console.ReadLine());
        
        while (t-- > 0)
        {
            // Read the array as input
            string[] arr1Str = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr1Str, int.Parse);
            
            Solution ob = new Solution();
            int ans = ob.Print2Largest(arr.ToList());
            
            // Print the result
            Console.WriteLine(ans);
        }
    }
}

public class Solution
{
    // Method to find the second largest element
    public int Print2Largest(List<int> arr)
    {
        int largest=0;
        int seclargest=0;
        
        for(int i=0;i<arr.Count;i++){
            if(arr[i]>largest){
                largest=arr[i];
            }
        }
        
        for(int i=0;i<arr.Count;i++){
            if(arr[i]!=largest  && arr[i]>seclargest){
                seclargest=arr[i];
            }
        }
        
        return seclargest==-1?-1:seclargest;
    }
}

