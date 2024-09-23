//Array Rotation

using System;

public class Solution 
{
    // Right Rotation by 1
    static int[] rotateArrayRight(int[] arr, int n) 
    {
        int[] res = new int[n];  // Corrected array declaration

        for (int i = 0; i < n; i++)
        {
            res[(i + 1) % n] = arr[i];  // Right rotation by 1 using modulo
        }

        return res;
    }

    // Left Rotation by 1
    static int[] rotateArrayLeft(int[] arr, int n) 
    {
        int[] res = new int[n];  // Initialize a new result array

        for (int i = 0; i < n; i++)
        {
            res[i] = arr[(i + 1) % n];  // Left rotation by 1 using modulo
        }

        return res;
    }

    static void Main(string[] args)
    {
        //int[] array1 = {1, 3, 5, 7, 9};  //// Output: 9 1 3 5 7
        int[] array1={1,2,3,4,5};   // output:Right Rotation: 5 1 2 3 4

        // Right Rotation
        int[] resultRight = rotateArrayRight(array1, array1.Length);
        Console.WriteLine("Right Rotation: " + string.Join(" ", resultRight)); 

        // Left Rotation
       int[] resultLeft = rotateArrayLeft(array1, array1.Length);
        Console.WriteLine("Left Rotation: " + string.Join(" ", resultLeft)); // Output: 3 5 7 9 1
    }
}
