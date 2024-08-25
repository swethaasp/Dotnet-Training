
            int[] arr = { 2, 8, 4, 3, 7 };
            int max = arr[0], i = 1;
            while(i<=4)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                i++;
            }
            //Console.WriteLine("The largest num in array: " + max);
            //Console.WriteLine("The largest num in array:{0} ",max);
            Console.WriteLine($"The largest num in array:{max} ");
        }
    }
}
