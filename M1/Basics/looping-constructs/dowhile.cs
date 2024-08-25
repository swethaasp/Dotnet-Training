//execute the statement atleast once before checking the condition 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Loops
    {
        static void Main(string[] args)
        {
            int n1, n2, r, mychoice;
            char ynchoice;

            do

            {

                Console.WriteLine("Enter first number");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter second number");
                n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("1 : + ");
                Console.WriteLine("2 : - ");
                Console.WriteLine("3 : *");
                Console.WriteLine("4 : / ");
                Console.WriteLine("5 : % ");
                Console.WriteLine("6 : Exit ");
                Console.WriteLine("Enter your choice .....(1 to 6) ");
                mychoice = Convert.ToInt32(Console.ReadLine());

                if (mychoice == 6)
                {
                    break;
                }
                else
                {
                    switch (mychoice)
                    {
                        case 1:
                            r = n1 + n2;
                            Console.WriteLine("Addition is : {0}", r);
                            break;

                        case 2:
                            r = n1 - n2;
                            Console.WriteLine("Subtraction is : {0}", r);
                            break;

                        case 3:
                            r = n1 * n2;
                            Console.WriteLine("Multiplication is : {0}", r);
                            break;

                        case 4:
                            r = n1 / n2;
                            Console.WriteLine("Division is : {0}", r);
                            break;

                        case 5:
                            r = n1 % n2;
                            Console.WriteLine("Modulo is : {0}", r);
                            break;

                        default:
                            r = n1 - n2;
                            Console.WriteLine("Invalid Choice");
                            break;
                    }

                }

                Console.WriteLine("Do you want to continue....Y/N");
                ynchoice = Convert.ToChar(Console.ReadLine());
            } while (ynchoice == 'y' || ynchoice == 'Y');

            }
        }

       

    }


