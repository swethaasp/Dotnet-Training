using System;
public class Exercise1
{
    public static void Main( )
    {
        string str=Console.ReadLine();
         int l=str.Length-1;
         while(l>=0){
             Console.WriteLine(str[l]);
             l--;
         }
    }
}
