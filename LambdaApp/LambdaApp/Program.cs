namespace LambdaApp
{
    internal class Program
    {

        delegate int ArOper(int x, int y);
        delegate void HelloDeleg();


        static void Main(string[] args)
        {

            //ArOper oper = new ArOper(MyOper.Sum);
            Func<int,int,int> oper = new Func<int, int, int>(MyOper.Sum);   
            // HelloDeleg hel = new HelloDeleg(MyOper.Hello1);
            Action hel = new Action(MyOper.Hello1);
            
           
            int k = oper(8, 3);
            Console.WriteLine(k);

            oper = MyOper.Minus;

            k = oper(8, 3);
            Console.WriteLine(k);

            oper += MyOper.Mult;

            k = oper(8, 3);
            Console.WriteLine(k);

            oper = MyOper.Div;

            k = oper.Invoke(8, 3);
            Console.WriteLine(k);

            oper = delegate (int x, int y)
            {
                return 2 * x - 3 * y;
            };

            k = oper.Invoke(8, 3);
            Console.WriteLine($"anonim method {k}");

            oper = (x,y) => x * x - y * y;

            k = oper.Invoke(8, 3);
            Console.WriteLine($"lambda -  {k}");



            Console.WriteLine("***************************");

            hel.Invoke();
            //hel += MyOper.Hello1;

            //hel += MyOper.Hello1;
            //hel += MyOper.Hello2;
            //hel += MyOper.Hello2;
            //hel += MyOper.Hello2;
            //hel += MyOper.Hello2;
            hel += MyOper.Hello2;
            hel += delegate ()
            {
                Console.WriteLine("Hello from anonim method");
            };

            hel += () =>
            {
                Console.WriteLine("Hello from lambda");
            };

            //if(hel != null)
            //    hel();
            hel?.Invoke();




        }
    }
}
