using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar3
{
    internal class Task6
    {
        
        
        
        static void Main6(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student() { Name = "Василий", Age = 24 },
                new Student() { Name = "Мария", Age = 21 },
                new Student() { Name = "Саша", Age = 19 },
                new Student() { Name = "Янис", Age = 24 },
            };

            var sortStudents = students.Where(x => x.Age > 20).OrderBy(x => x.Name);

            foreach (var s in sortStudents)
            {
                Console.WriteLine(s.Name);
            }
        }


        public class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}
