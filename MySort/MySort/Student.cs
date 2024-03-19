using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MySort
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<int> Marks { get; set; } = new List<int>();

        public override string ToString()
        {
            return $"{Id} {Name} {Age} {Marks.Average()}";
        }
    }


    public class  Group
    {
        public List<Student> Students { get; set; } = new List<Student>();

        public void Sort(Func<Student,Student, bool> func)
        {
            int n = Students.Count;
            bool fl = true;
            for(int i = 0; i < n; i++) 
                for(int j = 0; j < n - i - 1; j++)
                    if ( func(Students[j], Students[j+1]) )
                    {
                        var s = Students[j];
                        Students[j] = Students[j + 1];
                        Students[j + 1] = s;
                    }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var student in Students) 
            {
                sb.AppendLine(student.ToString());
            }
            return sb.ToString();
        }

    }
}
