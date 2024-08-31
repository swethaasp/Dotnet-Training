namespace Day_5_Copy_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str=Console.ReadLine();
            //string cpy = new string(str);
            //Console.WriteLine(cpy);

            string[] cpy = new string[str.Length];
            int i = 0;
            while (i < str.Length)
            {
                //cpy[i] = str[i];
                string temp = str[i].ToString();
                cpy[i] = temp;
                i++;
            }
            Console.WriteLine(string.Join("",cpy));
        }
    }
}
