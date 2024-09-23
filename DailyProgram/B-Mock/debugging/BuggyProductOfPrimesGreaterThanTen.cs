using System;
using System.Collections.Generic;

class Solution
{
    // Function to check if a number is prime
    public static bool IsPrime(int num)
    {
        if (num <= 1) return false;  
        if (num<=3) return true;  
        if (num % 2 == 0  || num%3==0) return false; 
        
        int i=5;
        while(i*i<=num){
           if (num % i == 0 || num%(i+2)==0) return false;  // Not prime  
           i+=6;
        }
        return true;  
    }

    /
    public static int BuggyProductOfPrimesGreaterThanTen(int n, List<int> arr)
    {
        int product = 1;
        bool foundPrime = false;  

        foreach (var num in arr)
        {
            if (num > 10 && IsPrime(num))   //num<10==>num>10
            {
                product *= num;
                
            }
        }

        return  product ;
    }

    public static void Main(string[] args)
    {
        // Read the number of integers
        int n = Int32.Parse(Console.ReadLine().Trim());

        // Initialize the list to store the integers
        List<int> arr = new List<int>();

        // Read the integers and add them to the list
        for (int i = 0; i < n; i++)
        {
            arr.Add(Int32.Parse(Console.ReadLine().Trim()));
        }

        // Call the BuggyProductOfPrimesGreaterThanTen function and print the result
        int result = BuggyProductOfPrimesGreaterThanTen(n, arr);
        Console.WriteLine(result);
    }
}

