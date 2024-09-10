https://www.entityframeworktutorial.net/code-first/what-is-code-first.aspx
public class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public byte[]  Photo { get; set; }
    public decimal Height { get; set; }
    public float Weight { get; set; }
        
    public Grade Grade { get; set; }
}

public class Grade
{
    public int GradeId { get; set; }
    public string GradeName { get; set; }
    public string Section { get; set; }
    
    public ICollection<Student> Students { get; set; }
}

namespace EF6Console
{
    public class SchoolContext: DbContext 
    {
        public SchoolContext(): base()
        {
            
        }
            
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
    }
}

namespace EF6Console
{
    class Program
    {
        static void Main(string[] args)
        {
     
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Bill" };
        
                ctx.Students.Add(stud);
                ctx.SaveChanges();                
            }
        }
    }
}

