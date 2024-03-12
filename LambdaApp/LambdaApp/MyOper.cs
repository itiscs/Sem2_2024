using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaApp
{
    public class MyOper
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }
        public static int Mult(int a, int b)
        {
            return a * b;
        }
        public static int Div(int a, int b)
        {
            return a / b;
        }


        public static void Hello1()
        {
            Console.WriteLine("Hello 1");
        }

        public static void Hello2()
        {
            Console.WriteLine("Hello 2");
        }


    }
}
