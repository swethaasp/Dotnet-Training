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
        
        Console.WriteLine($"After swapping: the value of a is {a} and b is {b}");
    }
}
