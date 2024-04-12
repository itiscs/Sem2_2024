namespace ThreadApp
{
    internal class Program
    {

        public static int sum = 0, p = 4;
        public static int n = 5000000;
        public static int[] arr, sum3;
        static void Main(string[] args)
        {

            sum3 = new int[p];
            arr = new int[n];
            int sum2 = 0;


            Random r = new Random();

            for(int i = 0; i< n; i++)
            {
                arr[i] = r.Next(0,1000);
            }


            DateTime t1 = DateTime.Now;
            for (int i = 0; i < n; i++)
            {
                sum2 += arr[i];
            }
            Console.WriteLine($"Время последовательно - {(DateTime.Now - t1).TotalMilliseconds}");



            Thread thread1 = new Thread(() => Sum(0));
            Thread thread2 = new Thread(() => Sum(1));
            Thread thread3 = new Thread(() => Sum(2));
            Thread thread4 = new Thread(() => Sum(3));


            //Thread thread1 = new Thread(Print);
            //Thread thread2 = new Thread(Print);
            //Thread thread3 = new Thread(Print);
            //Thread thread4 = new Thread(Print);
            //Thread thread5 = new Thread(Print);

            t1 = DateTime.Now;

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();

            thread1.Join();
            thread2.Join();
            thread3.Join();
            thread4.Join();
            
            for (int i = 0; i < p; i++)
                sum += sum3[i];

            //sum = sum3[0] + sum3[1] + sum3[2] + sum3[3];
            Console.WriteLine($"Время параллельно - {(DateTime.Now - t1).TotalMilliseconds}");


            Console.WriteLine($"sum = {sum}   sum2 = {sum2}");

            //Print();


        }

        

        public static void Sum(int id)
        {
            int i1 = id * (n / p);
            int i2 = (id+1) * (n / p);
            Console.WriteLine($"thread {id} i1 = {i1} i2 = {i2}");

            for (int i = i1; i < i2; i++)
                sum3[id] += arr[i];



        }


        static void Print()
        {
            Thread currentThread = Thread.CurrentThread;

            Thread.Sleep(100*currentThread.ManagedThreadId);

            //получаем имя потока
            //Console.WriteLine($"Имя потока: {currentThread.Name}");
            currentThread.Name = $"Поток {currentThread.ManagedThreadId}";
            Console.WriteLine($"Имя потока: {currentThread.Name}");

            Console.WriteLine($"Запущен ли поток: {currentThread.IsAlive}");
            Console.WriteLine($"Id потока: {currentThread.ManagedThreadId}");
            Console.WriteLine($"Приоритет потока: {currentThread.Priority}");
            Console.WriteLine($"Статус потока: {currentThread.ThreadState}");

        }
    }
}
