using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Employee
    {
        protected int eid;
        protected string ename;


        class Parttime : Employee
        {
           public  int noofhrs;

            static void Main(string[] args)
            {
                Parttime p = new Parttime();
                p.noofhrs = 5;
                p.eid = 110;
                p.ename = "ABC";

            }
        }

        class Fulltime : Employee
        {
            public int shift;
        }
        class Program
        {
            

        }
    }
}




//alt

    //2


    class Animal
    {
        public Animal()
        {
            Console.WriteLine("constructor of Animal");
        }

        ~Animal()
        {
            Console.WriteLine("destructor of Animal");
        }
    }

    class Cat : Animal
    {
         public Cat()
        {
            Console.WriteLine("constructor of cat");
        }
        ~ Cat()
        {
            Console.WriteLine("destructor of cat");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
          Cat obj = new Cat();
          
        }// when main end,the destructor of objects will be called
    }
}





//alt -parameterized

    //2


    class Animal
    {
        public Animal()
        {
            Console.WriteLine("constructor of Animal");
        }
        public Animal(int w)
        {
            Console.WriteLine("constructor of Animal with one param : {0}",w);
        }

        ~Animal()
        {
            Console.WriteLine("destructor of Animal");
        }
    }

    class Cat : Animal
    {
         public Cat()
        {
            Console.WriteLine("constructor of cat");
        }

        public Cat(int n)
        {
            Console.WriteLine("constructor of cat with one param : {0}", n);
        }
        ~ Cat()
        {
            Console.WriteLine("destructor of cat");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
          Cat obj = new Cat(45); //here constructor of parent class get called first  .also default Animal constr called(coz , we assign cat with params).then child class with params called
          
        }// when main end,the destructor of objects will be called
    }
}


// child class const(int n) : base(n)

    class Animal
    {
        public Animal()
        {
            Console.WriteLine("constructor of Animal");
        }
        public Animal(int w)
        {
            Console.WriteLine("constructor of Animal with one param : {0}",w);
        }

        ~Animal()
        {
            Console.WriteLine("destructor of Animal");
        }
    }

    class Cat : Animal
    {
         public Cat()
        {
            Console.WriteLine("constructor of cat");
        }

        public Cat(int n):base(20)  //calls child class with params (n-return same val to parent , 20 -return 20 to parent and 45 to child)
        {
            Console.WriteLine("constructor of cat with one param : {0}", n);
        }
        ~ Cat()
        {
            Console.WriteLine("destructor of cat");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
          Cat obj = new Cat(45); //here constructor of parent class get called first  .also default Animal constr called(coz , we assign cat with params).then child class with params called
          
        }// when main end,the destructor of objects will be called
    }
}

