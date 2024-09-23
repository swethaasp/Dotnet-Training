using System;
using System.Collections.Generic;

public class MainClass
{
    public static void Main(string[] args)
    {
        // Input the number of test cases
        int t = int.Parse(Console.ReadLine());
        
        for (int g = 0; g < t; g++)
        {
            // Read the array as input
            string[] str = Console.ReadLine().Trim().Split(' ');
            int[] arr = Array.ConvertAll(str, int.Parse);
            
            // Create an instance of Solution and find the majority element
            Console.WriteLine(Solution.MajorityElement(arr));
        }
    }
}

public class Solution
{
    public static int MajorityElement(int[] arr)
    {
        Dictionary<int,int> dt =new Dictionary<int,int>();
        foreach(int num in arr){
            if(dt.ContainsKey(num)){
                dt[num]++;
            }
            else{
                dt[num]=1;
            }
        }
        
        int target=arr.Length/2;
        
        foreach(var value in dt){
            if(value.Value>target){
                return value.Key;
            }
        }
        return -1;
    }
}
