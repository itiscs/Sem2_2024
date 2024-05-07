using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MultiSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = 10000;
            var p = 4;

            Console.WriteLine(n * Math.Log2(n));

            Console.WriteLine((n / p) * Math.Log2(n / p) + Math.Log2(p) * n / 2);

            Random r = new Random();
            var myArr = new MyArray<int>(n);
            myArr.Init(() => r.Next());

            var t1 = DateTime.Now;
            myArr.Sort(1);
            Console.WriteLine(DateTime.Now - t1);

            Console.WriteLine(myArr.IsSorted(0, myArr.Length));

            myArr.Init(() => r.Next());
            t1 = DateTime.Now;
            myArr.Sort(p);
            Console.WriteLine(DateTime.Now - t1);

            Console.WriteLine(myArr.IsSorted(0, myArr.Length));
        }
    }
}
