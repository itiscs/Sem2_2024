namespace MySort
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var gr = new Group();
            gr.Students.Add(new Student()
            {
                Id = 1,
                Name = "Ivan",
                Age = 22,
                Marks = new List<int> { 3, 4, 5, 5, 5 }
            });
            gr.Students.Add(new Student()
            {
                Id = 2,
                Name = "Pet",
                Age = 21,
                Marks = new List<int> { 5, 5, 5, 5, 5 }
            }); 
            gr.Students.Add(new Student()
            {
                Id = 3,
                Name = "Maria",
                Age = 18,
                Marks = new List<int> { 3, 4, 3, 3, 3 }
            }); 
            gr.Students.Add(new Student()
            {
                Id = 4,
                Name = "Anna",
                Age = 25,
                Marks = new List<int> { 3, 4, 4, 4, 5 }
            }); 
            gr.Students.Add(new Student()
            {
                Id = 5,
                Name = "Alexander",
                Age = 20,
                Marks = new List<int> { 3, 3, 3, 5, 5 }
            });



            Console.WriteLine(gr);

            Console.WriteLine("***********************************");
            gr.Sort((x, y) => x.Age > y.Age);

            Console.WriteLine(gr);

            Console.WriteLine("***********************************");

            gr.Sort((x, y) => x.Name.CompareTo(y.Name) >= 0);

            Console.WriteLine(gr);

            Console.WriteLine("***********************************");

            gr.Sort((x, y) => x.Name.Length > y.Name.Length);

            Console.WriteLine(gr);

            Console.WriteLine("***********************************");



            gr.Sort((x, y) => x.Id > y.Id);

            Console.WriteLine(gr);

        }
    }
}
