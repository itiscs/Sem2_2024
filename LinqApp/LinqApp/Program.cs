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

            foreach(int i in lst1) 
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("************************");

            List<string> lst2 = new List<string>() {"aaaaaa","bbbbbbbb",
            "avvvvv", "ccccccca"};

            var lst3 = lst2.Where(s => s.Contains('a') || s.Contains('b'))
                .OrderBy(s => s[s.Length-1])
                .ThenByDescending(s => s.Length);

            foreach (var i in lst3)
            {
                Console.WriteLine(i);
            }



        }
    }
}
