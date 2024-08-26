//methods


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class methods
    {
        string name;
        string email;
        int phoneno;

        public void Assign()
        {
            Console.WriteLine("Enter ur name");
            name = Console.ReadLine();
            Console.WriteLine("Enter email");
            email = Console.ReadLine();
            Console.WriteLine("Enter ur phoneno");
            phoneno = Convert.ToInt32( Console.ReadLine());
        }

        public void print()
        {
            Console.WriteLine("{0}", name);
            Console.WriteLine("{0}", email);
            Console.WriteLine("{0}", phoneno);
        }
        
        static void Main(string[] args)
        {
            methods maria = new methods();
            maria.Assign();
            maria.print();
            methods smith = new methods();
            smith.Assign();
            smith.print();

        }
    }
}
