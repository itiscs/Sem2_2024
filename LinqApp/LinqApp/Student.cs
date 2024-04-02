using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqApp
{
    public class Student
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<int> Marks { get; set; } = new List<int>();

        public override string ToString()
        {
            return $"{Id} {Name} {GroupId} {Age} {Marks.Average()}";
        }
    }


    public class Group
    {
        public int Id { get; set; }
        public string GroupNum { get; set; }
        public string Faculty { get; set; }
        public string Speciality { get; set; }

        public override string ToString()
        {
            return $"{Id} {GroupNum} {Faculty} {Speciality}";
        }


    }

}