Extension methods enable you to "add" methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type.

static void Main(string[] args)
{
    string name = "ram kumar";
    Console.WriteLine(name);
    string uname = name.ToUpper();
    Console.WriteLine(uname);

    //below is LINQ example using inbuilt OrderBy extension method
    int[] ints = [10, 45, 15, 39, 21, 26];
    var result = ints.OrderBy(g => g);
    foreach (var i in result)
    {
        System.Console.Write(i + " ");
    }
}

Extension methods are defined as static methods but are called by using instance method syntax. 
