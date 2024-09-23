breach qn

using System;

namespace USTPraxis
{
    public class BreachCountWithSemicolon
    {
        private static int FindBreachCount(string logs)
        {
            int count = 0;
            logs = logs.ToLower();
            string[] slogs = logs.Split(";");
            foreach (string log in slogs)
            {
                if (log.Contains("breach"))
                {
                    count++;
                }
            }
            return count;
        }

        public static void Main(string[] args)
        {
            string logs = Console.ReadLine();
            int result = FindBreachCount(logs);
            Console.WriteLine(result);
        }
    }
}


//breach breach ;ahdjc breach;abreach;1234;   //3
//no breach here;breach is found;multiplebreachbreach here ;nothing to see;  //3
