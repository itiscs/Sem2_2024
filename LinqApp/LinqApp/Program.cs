using System.Text.RegularExpressions;

namespace LinqApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> lst = new List<int>() { 1,2,3,4,5,2,1,4,2,1,5,6,8,9,-34,34,
            -5,-6,-8};

            var lst1 = lst.Where(k => k % 3 == 2)
                .OrderByDescending(k => k)
               .Take(3);//.First();

            foreach (int i in lst1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("************************");

            List<string> lst2 = new List<string>() {"aaaaaa","bbbbbbbb",
            "avvvvv", "ccccccca"};

            var lst3 = lst2.Where(s => s.Contains('a') || s.Contains('b'))
                .OrderBy(s => s[s.Length - 1])
                .ThenByDescending(s => s.Length)
                .Select(s => s[0]);

            foreach (var i in lst3)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("************************");


            var gr = new List<Student>();
            gr.Add(new Student()
            {
                Id = 1,
                GroupNum = 308,
                Name = "Ivan",
                Age = 22,
                Marks = new List<int> { 3, 4, 5, 5, 5 }
            });
            gr.Add(new Student()
            {
                Id = 2,
                Name = "Petr",
                GroupNum = 308,
                Age = 21,
                Marks = new List<int> { 5, 5, 5, 5, 5, 5 }
            });
            gr.Add(new Student()
            {
                Id = 3,
                Name = "Maria",
                GroupNum = 308,
                Age = 18,
                Marks = new List<int> { 3, 4, 3, 3, 3 }
            });
            gr.Add(new Student()
            {
                Id = 4,
                Name = "Anna",
                GroupNum = 307,
                Age = 25,
                Marks = new List<int> { 3, 4, 4, 4, 5 }
            });
            gr.Add(new Student()
            {
                Id = 5,
                Name = "Alexander",
                GroupNum = 307,
                Age = 20,
                Marks = new List<int> { 3, 3, 3, 5, 5 }
            });
            gr.Add(new Student()
            {
                Id = 6,
                Name = "Serg",
                GroupNum = 309,
                Age = 20,
                Marks = new List<int> { 4, 4, 4, 5, 5 }
            });


            //var newGr = gr.Where(s => s.Marks.Average() > 2)
            //    .OrderBy(s => s.Age)
            //    .Select(s => new { s.Name, s.Age })
            //    .Where(a => a.Age > 20);
            //    //.Max(a => a.Name);

            //foreach (var st in newGr)
            //{
            //    Console.WriteLine(st);
            //}



            var newGr = gr.GroupBy(s => s.GroupNum)//.Name.Length)
                .Select(g => new { g.Key, Count = g.Count(),
                MaxAge = g.Max(s => s.Age),
                AllMarks = g.SelectMany(s=>s.Marks)});


            foreach(var s in newGr)
            {
                Console.WriteLine(s);
                foreach (var m in s.AllMarks)
                    Console.Write($" {m}");
                Console.WriteLine();
            }

            //foreach(var g in newGr )
            //{
            //    Console.WriteLine(g.Key);
            //    foreach(var st in g)
            //    {
            //        Console.WriteLine($"    {st}");
            //    }
            //}





        }
    }
}
