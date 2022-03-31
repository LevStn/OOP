using Lists;



LinkedList list = new LinkedList();

list.AddToBegin(23);
list.AddToBegin(23);
list.AddToBegin(23);

list.WriteLinkedList();


LinkedList list2 = new LinkedList();

list2.AddToBegin(2);
list2.AddToBegin(2);
list2.AddToBegin(2);


list.AddListToIndex(list2,1);
list.WriteLinkedList();

//list.AddListToEnd(list2);


