using Lists;



LinkedList list = new LinkedList();

list.AddToEnd(55);
list.AddToEnd(22);
list.AddToEnd(66);
list.AddToEnd(77);
list.AddToEnd(88);
list.AddToEnd(1);
list.AddToEnd(2);
list.AddToEnd(2);
list.AddToEnd(3);
list.AddToEnd(3);
list.AddToEnd(3);
list.AddToEnd(3);

LinkedList list2 = new LinkedList();
list2.AddToEnd(550000000);

list.AddListToEnd(list2);

int a =list.FindFirstIndexByValue(5);
list.WriteLinkedList();

Console.WriteLine($"Result{a}");