using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Basics
{
    class Program1
    {
        static void Main(string[] args)
        {            char ch;
            Console.WriteLine("Enter the character a to z");
            ch =Convert.ToChar(Console.ReadLine());

            switch(ch)
            {
                case 'a':
                    Console.WriteLine("Vowel");
                    break;

                case 'e':
                    Console.WriteLine("Vowel");
                    break;

                case 'i':
                    Console.WriteLine("Vowel");
                    break;

                case 'o':
                    Console.WriteLine("Vowel");
                    break;

                case 'u':
                    Console.WriteLine("Vowel");
                    break;

                default:
                    Console.WriteLine("Character is not a vowel ");
                    break;

            }

        }
    }
}

Enter the character a to z
e
Vowel


//one more approach
            char ch;
            Console.WriteLine("Enter the character a to z");
            ch =Convert.ToChar(Console.ReadLine());

            switch(ch)
            {
                case 'a':

                case 'e':

                case 'i':
                    

                case 'o':
                   

                case 'u':
                    Console.WriteLine("Vowel");
                    break;

                default:
                    Console.WriteLine("Character is not a vowel ");
                    break;

            }

        }
    }
}
Enter the character a to z
e
Vowel

