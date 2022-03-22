using Lists;




ArrayList list=new ArrayList();

list.AddValuesToTheEnd(1);
list.Write();
list.AddValuesToTheEnd(2);
list.Write();
list.AddValuesToTheEnd(3);
list.Write();
list.AddValuesToTheEnd(4);
list.Write();
list.AddValuesToTheEnd(0);
list.Write();
list.AddValuesToTheEnd(2);
list.Write();
list.AddValuesToTheEnd(5);
list.Write();

list.DeleteByValueFirst(2);
list.Write();



Console.WriteLine(list.DeleteByValueFirst(2));


