namespace ConsoleMenuApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Меню!");

                Console.WriteLine("1. Список товаров");
                Console.WriteLine("2. Добавить товар");
                Console.WriteLine("3. Создать заказ");
                Console.WriteLine("4. Список товаров");
                Console.WriteLine("5. Добавить товар");

                Console.WriteLine("6. Выход");

                var k = int.Parse(Console.ReadLine());

                if (k == 6)
                    return;

                switch (k)
                {
                    case 1: Console.WriteLine("Список товаров!");
                        break;
                    case 2:
                        Console.WriteLine("Список товаров!");
                        break;
                    case 3:
                        Console.WriteLine("Список товаров!");
                        break;
                    case 4:
                        Console.WriteLine("Список товаров!");
                        break;
                    case 5:
                        Console.WriteLine("Список товаров!");
                        break;
                    default:
                        Console.WriteLine("Я вас не понимаю");
                        break;
                }

                Console.ReadKey();

            }


        }
    }
}
