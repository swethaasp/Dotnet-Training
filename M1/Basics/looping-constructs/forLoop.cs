//fixed type loops-know no.of iterations



            for(int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for (int i = 10; i >=1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}



//check the count of even no and odd nos

            int num, ecount = 0, ocount = 0;
           

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Enter the number");
                num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0)
                {
                    ecount++;
                }
                else
                {
                    ocount++;
                }


            }

            Console.WriteLine("no.of  even : {0} and  no of odd : {1} ", ecount, ocount);
        }
    }
}


//star pattern

            int rows;
            Console.WriteLine("Enter no.of rows");
            rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                // for(int j = 0; j < i; j++)
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }
    }
}

Enter no.of rows
5
 *
 *  *
 *  *  *
 *  *  *  *
 *  *  *  *  *


//

            int rows;
            Console.WriteLine("Enter no.of rows");
            rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                // for(int j = 0; j < i; j++)
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
Enter no.of rows
4
1
1 2
1 2 3
1 2 3 4

  //

              int rows;
            Console.WriteLine("Enter no.of rows");
            rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                // for(int j = 0; j < i; j++)
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

Enter no.of rows
4
1
2 2
3 3 3
4 4 4 4


  //
              int rows;
            Console.WriteLine("Enter no.of rows");
            rows = Convert.ToInt32(Console.ReadLine());

            for (int i = rows; i >=1; i--)
            {
                // for(int j = 0; j < i; j++)
                for (int j = i; j >=1; j--)
                {
                    Console.Write( "  * ");
                }
                Console.WriteLine();
            }
        }
    }
}

Enter no.of rows
4
  *   *   *   *
  *   *   *
  *   *
  *
