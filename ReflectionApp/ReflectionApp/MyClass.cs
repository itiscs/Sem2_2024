using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionApp
{
    public class MyClass
    {
        private int p1;

        public string p2;

        public int Prop1 { get => p1; set => p1 = value; }

        public MyClass(int par1, string par2)
        {   
            p1 = par1;
            p2 = par2;
        }


        public MyClass():this(100,"Hello")
        {
        }


        private void PrivMethod()
        {
            Console.WriteLine("Private method");
        }

        public void Method1(int k)
        {
            p1 += k;
        }

        public string Method2()
        {
            return $"{p2} + {p1}";
        }

    }
}
