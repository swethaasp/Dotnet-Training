using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Basics
{
    class Program1
    {
        public static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("Enter the first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;

            Console.WriteLine("The sum of num1 and num2 is :{0}", sum);





        }
    }
}




Certainly! Here's how you can convert user input from `Console.ReadLine()` to other data types in C#:

1. **`int`**:
   - **Conversion**: `Convert.ToInt32(Console.ReadLine());`
   - **Purpose**: Converts the input string to an integer.

2. **`double`**:
   - **Conversion**: `Convert.ToDouble(Console.ReadLine());`
   - **Purpose**: Converts the input string to a double (floating-point number).

3. **`float`**:
   - **Conversion**: `Convert.ToSingle(Console.ReadLine());`
   - **Purpose**: Converts the input string to a float (single-precision floating-point number).

4. **`decimal`**:
   - **Conversion**: `Convert.ToDecimal(Console.ReadLine());`
   - **Purpose**: Converts the input string to a decimal, often used for financial calculations due to its higher precision.

5. **`bool`**:
   - **Conversion**: `Convert.ToBoolean(Console.ReadLine());`
   - **Purpose**: Converts the input string to a boolean (true/false).

6. **`char`**:
   - **Conversion**: `Convert.ToChar(Console.ReadLine());`
   - **Purpose**: Converts the input string to a character. Note: Ensure the input string contains exactly one character.

7. **`string`**:
   - **Conversion**: `Console.ReadLine();`
   - **Purpose**: Reads the input as a string. No conversion needed since `Console.ReadLine()` returns a string by default.

8. **`DateTime`**:
   - **Conversion**: `Convert.ToDateTime(Console.ReadLine());`
   - **Purpose**: Converts the input string to a `DateTime` object, representing a specific date and time.

9. **`long`**:
   - **Conversion**: `Convert.ToInt64(Console.ReadLine());`
   - **Purpose**: Converts the input string to a long integer (for larger whole numbers).

10. **`short`**:
    - **Conversion**: `Convert.ToInt16(Console.ReadLine());`
    - **Purpose**: Converts the input string to a short integer.

These conversion methods are useful when you're dealing with different types of data input in console applications.
