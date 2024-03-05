using StackApp;

Random r  = new Random();
var l = new OrderedList<Product>();


l.Add(new Product() { Id = 1, Name = "Product 1", Price = 100 });

l.Add(new Product() { Id = 2, Name = "Product 2", Price = 10 });
l.Add(new Product() { Id = 3, Name = "Product 3", Price = 50 });
l.Add(new Product() { Id = 4, Name = "Product 4", Price = 110 });
l.Add(new Product() { Id = 5, Name = "Product 5", Price = 5 });
//l.Add(new Product() { Id = 3, Name = "Product 3", Price = 50 });

//l.Add(new Product() { Id = 5, Name = "Product 5", Price = 5 });


Console.WriteLine(l);
Console.WriteLine("*******************************");

MyLinkedList<int> lst = new MyLinkedList<int>();

//for (int i = 0; i < 10; i++)
    lst.AddLast(5);

lst.AddLast(6);
//for (int i = 0; i < 10; i++)
    lst.AddLast(5);

Console.WriteLine("********** ENumerator **************");
foreach(int i in lst)
{
    Console.WriteLine(i);
}

Console.WriteLine("***********************");
foreach (int i in lst)
{
    Console.WriteLine(i);
}

Console.WriteLine("***********************");



Console.WriteLine(lst);
lst.RemoveValue(5);
Console.WriteLine(lst);



MyLinkedList<string> l2 = new MyLinkedList<string>();

l2.AddLast("a");
l2.AddLast("abc");
l2.AddLast("xxx");
l2.AddLast("zzz");

Console.WriteLine("***********************");

foreach (var i in l2)
{
    Console.WriteLine(i);
}
Console.WriteLine("***********************");


Console.WriteLine(l2);
l2.RemoveValue("a");
Console.WriteLine(l2);

