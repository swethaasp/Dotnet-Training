namespace DelegateDemo
{
    public class Program
    {
        static void Add(int i, int j)
        {
            Console.WriteLine("Sum :" + (i + j));
        }
        static void Sub(int i, int j)
        {
            Console.WriteLine("Sub :" + (i - j));
        }
 
        static void Multiply(int i, int j)
        {
            Console.WriteLine("Multiplication :" + (i * j));
        }
        //access-modifiers delegate return-type method-name ( parameter-list )
        public delegate void MyMethod(int x, int y);
 
        static void Main(string[] args)
        {
            Add(10, 2);
            Sub(50, 35);
 
            //instantiated delegate MyMethod
 
            MyMethod method = Add;
            Console.WriteLine("Using Delegate to Add");
            method(20, 30);
 
            method += Sub;
            Console.WriteLine("Using Delegate to Add and Sub");
            method(50, 25);
 
            method += Multiply;
            Console.WriteLine("Using All three (Add, Sub and Multiply");
 
            method(10, 5);
 
            method -= Sub;
            Console.WriteLine("After removing Sub from Delegate chain");
            method(7, 5);
 
        }
    }
}
