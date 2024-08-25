            int a;
            Console.WriteLine("Enter a number");

            a=Convert.ToInt32(Console.ReadLine());

            if (a % 5 == 0)
            {
                Console.WriteLine("Entered number is divisible by 5");
            }
            else
            {
                Console.WriteLine("Entered number  is not diviisible by 5");
            }
        }
    }
}


//alt
            int a;
            Console.WriteLine("Enter a number");

            a=Convert.ToInt32(Console.ReadLine());

            int rem = a % 10;  //unit digit

            if (rem == 0  || rem ==5) 
            {
                Console.WriteLine("Entered number is divisible by 5");
            }
            else
            {
                Console.WriteLine("Entered number  is not diviisible by 5");
            }
        }
    }
}
