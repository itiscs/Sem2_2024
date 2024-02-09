using StackApp;


MyLinkedList<int> lst = new MyLinkedList<int>();

for (int i = 0; i < 10; i++)
    lst.AddLast(i);

Console.WriteLine(lst);



MyLinkedList<string> l2 = new MyLinkedList<string>();

l2.AddLast("a");
l2.AddLast("abc");
l2.AddLast("xxx");
l2.AddLast("zzz");

Console.WriteLine(l2);

