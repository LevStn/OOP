using Lists;



LinkedList list = new LinkedList();



list.WriteLinkedList();


LinkedList list2 = new LinkedList();

list2.AddToBegin(2);
list2.AddToBegin(2);
list2.AddToBegin(2);


list.AddListToEnd(list2);
list2.WriteLinkedList();

//list.AddListToEnd(list2);


