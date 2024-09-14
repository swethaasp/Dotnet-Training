using System;

public class Program
{
    public static void Main()
    {
        // Prompt the user to enter the array elements
        Console.WriteLine("Enter the elements of the array separated by spaces:");
        string input = Console.ReadLine();
        
        // Convert the input string to an array of integers
        int[] nums = Array.ConvertAll(input.Split(), int.Parse);
        int res = find(nums);
        Console.WriteLine(res);
    }
    public static int find(int[] nums){
        int n = nums.Length;
        int expect = (n + 1)*(n + 2)/2;
        int realans = 0;
        foreach(int i in nums){
            realans += i;
        }
        return expect - realans; 
    }
}
