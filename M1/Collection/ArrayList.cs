using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class ArrayListDemo
    {
        static void Main(string[] args)
        {
            // Create an ArrayList and add elements
            ArrayList arr = new ArrayList();
            arr.Add(23);
            arr.Add("Education");
            arr.Add(34.89);
            arr.Add('F');
            arr.Add("Csharp");

            Console.WriteLine("Original ArrayList:");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            // Remove by element
            arr.Remove(34.89);
            Console.WriteLine("\nAfter removing 34.89:");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            // Remove by index
            arr.RemoveAt(2);
            Console.WriteLine("\nAfter removing element at index 2:");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            // Insert at specific index
            arr.Insert(1, "NewElement");
            Console.WriteLine("\nAfter inserting 'NewElement' at index 1:");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            // Reverse the ArrayList
            arr.Reverse();
            Console.WriteLine("\nAfter reversing the ArrayList:");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            // Sorting the ArrayList (will only work if all elements are of the same type)
            arr.Clear(); // Clear the ArrayList and add only comparable elements
            arr.Add(50);
            arr.Add(20);
            arr.Add(40);
            arr.Add(10);
            arr.Add(30);

            arr.Sort();
            Console.WriteLine("\nAfter sorting the ArrayList:");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            // TrimToSize to minimize memory overhead
            arr.TrimToSize();
            Console.WriteLine($"\nArrayList capacity after TrimToSize: {arr.Capacity}");
        }
    }
}


Original ArrayList:
23
Education
34.89
F
Csharp

After removing 34.89:
23
Education
F
Csharp

After removing element at index 2:
23
Education
Csharp

After inserting 'NewElement' at index 1:
23
NewElement
Education
Csharp

After reversing the ArrayList:
Csharp
Education
NewElement
23
