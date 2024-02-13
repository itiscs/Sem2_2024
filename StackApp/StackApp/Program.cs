using StackApp;



MyLinkedList<int> lst = new MyLinkedList<int>();

for (int i = 0; i < 10; i++)
    lst.AddLast(5);

lst.AddLast(6);
for (int i = 0; i < 10; i++)
    lst.AddLast(5);


Console.WriteLine(lst);
lst.RemoveValue(5);
Console.WriteLine(lst);



MyLinkedList<string> l2 = new MyLinkedList<string>();

l2.AddLast("a");
l2.AddLast("abc");
l2.AddLast("xxx");
l2.AddLast("zzz");

Console.WriteLine(l2);
l2.RemoveValue("a");
Console.WriteLine(l2);

