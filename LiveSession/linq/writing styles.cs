namespace LINQDemo2
{
 
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> integerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };
            //Step2: Query
            //LINQ Query using Query Syntax to fetch all numbers which are > 5
            var querySyntax = from num in integerList //Data Source
                              where num > 5 //Condition
                              select num; //Selection
            //Step3: Execution
            foreach (var item in querySyntax)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("=====================================");
 
            var methodSyntax = integerList.Where(num => num > 5).ToList();
            foreach (var item in methodSyntax)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("=====================================");
 
            var mixedSyntax = (from num in integerList
                               where num > 5
                               select num).Sum();
 
            Console.Write(mixedSyntax);
        }
    }
}
