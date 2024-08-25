            string[] arr = { "C", "s", "h", "r", "a", "p" };
            int i = 5;
            Console.Write("The reverse of the given string is :");
            while (i >= 0)
            {
                Console.Write(arr[i]);
                i--;
            }
           Console.Read();
        }
    }
}

//alt


            Char[] c;
            String ans="";
            int index = 0;
            c = Console.ReadLine().ToLower().ToCharArray();//string to cahr array
            for (int i = c.Length - 1; i >= 0; i--)
            {
                ans = ans + c[i].ToString();
            }
            Console.WriteLine(ans);
        }
    }
}

//alt
            char[] c;
            char[] ans;
            int index = 0;
            c = Console.ReadLine().ToLower().ToCharArray();//string to cahr array
            ans = new char[c.Length];
            for (int i = c.Length - 1; i >= 0; i--)
            {
                ans[index++] = c[i];
                
            }
            string soln = new string(ans);
         
            Console.WriteLine(soln);
        }
    }
}
