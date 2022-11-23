using System;

namespace EF6CodeFirstDemo
{
    /// <summary>
    /// https://github.com/entityframeworktutorial/EF6-Code-First-Demo
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var student = new Student() { StudentName = "Bill" };

                ctx.Students.Add(student);
                ctx.SaveChanges();
            }
            Console.WriteLine("Demo completed.");
            Console.ReadLine();
        }
    }
}