
using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace EntityFramework
{
        class Program
        {
            static void Main(string[] args)
            {
           /*
            using (EF_Demo_DBEntities DBEntities = new EF_Demo_DBEntities())
            {
                List<Student> listStudents = DBEntities.Students.ToList();
                Console.WriteLine();
                foreach (Student student in listStudents)
                {
                    Console.WriteLine($" Name = {student.FirstName} {student.LastName}, Email {student.StudentAddress?.Email}, Mobile {student.StudentAddress?.Mobile}");
                }
                Console.ReadKey();
            }
            */

            /*
           
            //Create a new student which you want to add to the database
            var newStudent = new Student()
            {
                FirstName = "Pranaya",
                LastName = "Rout",
                StandardId = 1
            };
            //Create DBContext object
            using (EF_Demo_DBEntities context = new EF_Demo_DBEntities())
            {
                //Add Student Entity into Students DBset by calling the Add Method
                context.Students.Add(newStudent);
                //Now the Entity State will be in Added State
                Console.WriteLine($"Before SaveChanges Entity State: {context.Entry(newStudent).State}");
                //If you want to see what SQL Statement it generates for Inserting the data, 
                //please use the following statement, it will log the SQL Statement in the console window
                context.Database.Log = Console.Write;
                //Call SaveChanges method to save student into database
                context.SaveChanges();
                //Now the Entity State will change from Added State to Unchanged State
                Console.WriteLine($"After SaveChanges Entity State: {context.Entry(newStudent).State}");
            }
            Console.ReadKey();

            */


            /*  update operation
               
                //Create DBContext object
                using (EF_Demo_DBEntities context = new EF_Demo_DBEntities())
                {
                    // Retrieve the student whose id is 3
                    var student = context.Students.Find(3);
                    //At this point Entity State will be Unchanged
                    Console.WriteLine($"Before Updating Entity State: {context.Entry(student).State}");
                    //Update the first name and last name
                    student.FirstName = "Sanju";
                    student.LastName = "Samson";
                    //At this point Entity State will be Modified
                    Console.WriteLine($"After Updating Entity State: {context.Entry(student).State}");
                    //If you want to see what SQL Statement it generates for Updating the data, 
                    //please use the following statement, it will log the SQL Statement in the console window
                    context.Database.Log = Console.Write;
                    //Call SaveChanges method to update student data into database
                    context.SaveChanges();
                    //Now the Entity State will change from Modified State to Unchanged State
                    Console.WriteLine($"After SaveChanges Entity State: {context.Entry(student).State}");
                }
                Console.ReadKey();

            */

            
            
            //Delete operation
            var newStudent = new Student()
            {
                FirstName = "Virat",
                LastName = "Kohli",
                StandardId = 1
            };
            //Create DBContext object
            using (EF_Demo_DBEntities context = new EF_Demo_DBEntities())
            {
                //If you want to Capture SQL Statements generates by the context object use the following statement 
                //it will log the SQL Statements in the console window
                context.Database.Log = Console.Write;
                //Add the entity to the context object
                context.Students.Add(newStudent);
                //At this point, the Entity State is Addedd
                //Console.WriteLine($"Entity State Before Removing: {context.Entry(newStudent).State}");
                //The following statement will cancel the addition of the Entity
                context.Students.Remove(newStudent);
                //At this point, the Entity State will be in Detached state
                Console.WriteLine($"Entity State After Removing: {context.Entry(newStudent).State}");

                //SaveChanges method will not do anything in the database
                context.SaveChanges();
            }
            Console.ReadKey();

           

            /*
            //read
            //Create DBContext object
            using (EF_Demo_DBEntities context = new EF_Demo_DBEntities())
            {
                //If you want to Capture SQL Statements generates by the context object, use the following statement 
                //it will log the SQL Statements in the console window 
                context.Database.Log = Console.Write;
                //Fetching All Records from the Student Database Table
                var AllStudents = context.Students.ToList();
                Console.WriteLine();
                //Printing the First Name and Last Name of All Students
                foreach (var student in AllStudents)
                {
                    Console.WriteLine($"FirstName : {student.FirstName} LastName : {student.LastName}");
                }
            }
            Console.ReadKey();
            */

        }
    }
}
        
    
        
