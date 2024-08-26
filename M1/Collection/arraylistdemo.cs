using System;
using System.Collections;

namespace Basics
{
    internal class ArrayListDemo
    {
        static void Main(string[] args)
        {
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

            // Using Contains
            Console.WriteLine("\nArrayList contains 'Education': " + arr.Contains("Education"));

            // Using IndexOf
            Console.WriteLine("\nIndex of 'Csharp': " + arr.IndexOf("Csharp"));

            // Using GetRange
            ArrayList subList = arr.GetRange(1, 3);
            Console.WriteLine("\nSublist from index 1 to 3:");
            foreach (var item in subList)
            {
                Console.WriteLine(item);
            }

            // Using AddRange
            arr.AddRange(new string[] { "X", "Y", "Z" });
            Console.WriteLine("\nAfter adding a range of elements:");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            // Using RemoveRange
            arr.RemoveRange(1, 2);
            Console.WriteLine("\nAfter removing range of elements from index 1:");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            // Using Clone
            ArrayList clonedArr = (ArrayList)arr.Clone();
            Console.WriteLine("\nCloned ArrayList:");
            foreach (var item in clonedArr)
            {
                Console.WriteLine(item);
            }

            // Using ToArray
            object[] array = arr.ToArray();
            Console.WriteLine("\nArray created from ArrayList:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}


output


Original ArrayList:
23
Education
34.89
F
Csharp

ArrayList contains 'Education': True

Index of 'Csharp': 4

Sublist from index 1 to 3:
Education
34.89
F

After adding a range of elements:
23
Education
34.89
F
Csharp
X
Y
Z

After removing range of elements from index 1:
23
F
Csharp
X
Y
Z

Cloned ArrayList:
23
F
Csharp
X
Y
Z

Array created from ArrayList:
23
F
Csharp
X
Y
Z

C:\Users\SWETHAA\source\repos\Solution\Basics\bin\Debug\net8.0\Basics.exe (process 4600) exited with code 0 (0x0).
To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.
Press any key to close this window . . .
