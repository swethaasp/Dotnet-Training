using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine($"Before swapping : the value of a is {a} and b is {b}");
        int temp=b;
        b=a;
        a=temp;

        /* Using Tuple Deconstruction
        int a = 5;
        int b = 10;
        (a, b) = (b, a);

        */

        /*
        int a = 5;
        int b = 10;
        a = a + b;
         b = a - b;
        a = a - b;
        */

       /*
        int a = 5;
       int b = 10;
       a = a ^ b;
       b = a ^ b;
      a = a ^ b;
        */

        /*LINQ
        int[] array = { 5, 10 };
         (array[0], array[1]) = (array[1], array[0]);

        */

        Console.WriteLine($"After swapping: the value of a is {a} and b is {b}");
    }
}
