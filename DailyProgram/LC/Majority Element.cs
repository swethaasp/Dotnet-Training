Given an array arr. Find the majority element in the array. If no majority exists, return -1.

A majority element in an array is an element that appears strictly more than arr.size()/2 times in the array.

Examples:

Input: arr[] = [3, 1, 3, 3, 2]
Output: 3
Explanation: Since, 3 is present more than n/2 times, so it is the majority element.
Input: arr[] = [7]
Output: 7
Explanation: Since, 7 is single element and present more than n/2 times, so it is the majority element.
Input: arr[] = [2, 13]
Output: -1
Explanation: Since, no element is present more than n/2 times, so there is no majority element.
Expected Time Complexity: O(n)
Expected Auxiliary Space: O(1)

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
                dt.Add(num,1);
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
