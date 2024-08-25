//variable type loop- dont know no.of iterations -dont till which no i need to check



            int cnt = 0; //count the 10 numbers
            int num = 1;
            
            while (cnt < 10)   //10 numbers
            {
                int flag = 0;
                num++;  //2 3 4 5 6 7 8 9 10 11
                
                for(int i = 2; i < num; i++)
                {
                    if (num% i == 0)
                    {
                        flag = 1;
                        break;
                    }
                }

                if (flag == 0)
                {
                    Console.WriteLine("{0} ", num);  //2 3 5 7 11
                    cnt++;
                }
               //1 2 3 4 5 6 7 8 9 10
            }
        }

Output
2
3
5
7
11
13
17
19
23
29
