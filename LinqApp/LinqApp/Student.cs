using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApp
{
    public class Student
    {
        public int Id { get; set; }

        public int GroupNum { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<int> Marks { get; set; } = new List<int>();

        public override string ToString()
        {
            return $"{Id} {Name} {GroupNum} {Age} {Marks.Average()}";
        }
    }
}
