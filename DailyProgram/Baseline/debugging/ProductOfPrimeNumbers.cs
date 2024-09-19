using System;
using System.Collections.Generic;

public class Solution
{
    // Function to check if a number is prime
    public static bool IsPrime(int num)
    {
        if (num < 2)
        {
            return false;  // 0 and 1 are not prime numbers
        }
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
            {
                return false;  // num is divisible by i, so it's not prime
            }
        }
        return true;
    }

    // Function to calculate the product of prime numbers in the list
    public static int ProductOfPrimeNumbers(int n, List<int> arr)
    {
        const int mod = 1000000007;
        long product = 1;
        bool hasPrime = false;  // To check if there's at least one prime number

        foreach (int num in arr)
        {
            if (IsPrime(num))
            {
                product = (product * num) % mod;  // Multiply prime numbers and apply modulus
                hasPrime = true;
            }
        }

        // If no prime numbers found, return 1
        return hasPrime ? (int)product : 1;
    }

    public static void Main(string[] args)
    {
        // Input the size of the array
        int n = int.Parse(Console.ReadLine().Trim());
        List<int> arr = new List<int>(n);

        // Input the array elements
        for (int i = 0; i < n; i++)
        {
            arr.Add(int.Parse(Console.ReadLine().Trim()));
        }

        // Calculate and print the product of prime numbers
        int result = ProductOfPrimeNumbers(n, arr);
        Console.WriteLine(result);
    }
}
