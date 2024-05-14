namespace ThreadApp
{
    internal class Program
    {

        public static int sum = 0, sum_par = 0, p = 8;
        public static int n = 10000000;
        public static int[] arr, sum3;

        static object locker = new object();
        static void Main(string[] args)
        {

            sum3 = new int[p];
            arr = new int[n];
            int sum2 = 0;


            Random r = new Random();

            for(int i = 0; i< n; i++)
            {
                arr[i] = r.Next(0,10);
            }

            sum2 = 0;
            DateTime t1 = DateTime.Now;
            for (int i = 0; i < n; i++)
            {
                sum2 += arr[i];
            }
            Console.WriteLine($"Время последовательно - {(DateTime.Now - t1).TotalMilliseconds}");

            var k = n / p;
            Console.WriteLine($"k = {k}");


            //Thread thread1 = new Thread(() => Sum(0, k));
            //Thread thread2 = new Thread(() => Sum(k, 2*k));
            //Thread thread3 = new Thread(() => Sum(2*k, 3*k));
            //Thread thread4 = new Thread(() => Sum(3*k, n));



            List<Task> tasks = new List<Task>();


            t1 = DateTime.Now;

            for (int i = 0; i < p; i++)
            {
                int num = i;
                tasks.Add(new Task(() => Sum(num)));
                //tasks[i].Start();
            }

            tasks.ForEach(t => t.Start());



            //Task task1 = new Task(() => Sum(0, k));
            //Task task2 = new Task(() => Sum(k, 2 * k));
            //Task task3 = new Task(() => Sum(2 * k, 3 * k));
            //Task task4 = new Task(() => Sum(3 * k, n));

            //Thread thread1 = new Thread(Print);
            //Thread thread2 = new Thread(Print);
            //Thread thread3 = new Thread(Print);
            //Thread thread4 = new Thread(Print);
            //Thread thread5 = new Thread(Print);

            // t1 = DateTime.Now;

            //tasks.ForEach(t => t.Start());

            //Parallel.For(0, p, Sum);


            //task1.Start();
            //task2.Start();
            //task3.Start();
            //task4.Start();

            //thread1.Start();
            //thread2.Start();
            //thread3.Start();
            //thread4.Start();

            //thread1.Join();
            //thread2.Join();
            //thread3.Join();
            //thread4.Join();


            //for (int i = 0; i < p; i++)
            //    sum += sum3[i];

            Task.WaitAll(tasks.ToArray());

            //sum = sum3[0] + sum3[1] + sum3[2] + sum3[3];
            Console.WriteLine($"Время параллельно - {(DateTime.Now - t1).TotalMilliseconds}");


            Console.WriteLine($"sum = {sum_par}   sum2 = {sum2}");

            //Print();



            Parallel.Invoke(
                Print,
                () =>
                {
                    Console.WriteLine("Вторая работа начинается");
                    Thread.Sleep(1000);
                    Console.WriteLine("Вторая работа заканчивается");
                },
                () => Square(5000));

        }


        public static void Square(long k )
        {
            Console.WriteLine($"Square = {k*k}");

        }
        

        public static void Sum(int id)
        {
            //Console.WriteLine($"thread {Thread.CurrentThread.ManagedThreadId} id = {id}");

            int k = n / p;
            int i1 = k * id;
            int i2 = k * (id + 1);

            int local_sum = 0;
            for (int i = i1; i < i2; i++)
                local_sum += arr[i];

            Console.WriteLine($"task {Task.CurrentId} i1 = {i1} i2 = {i2} local_sum = {local_sum}");

            lock (locker)
            {
                sum_par += local_sum;
            }


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
