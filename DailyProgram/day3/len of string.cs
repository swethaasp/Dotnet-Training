using System;
public class Exercise1
{
    public static void Main( )
    {
string str=Console.ReadLine();
         int len=0;
         foreach(char c in str){
             len++;
         }
         Console.WriteLine(len);
    }
}
