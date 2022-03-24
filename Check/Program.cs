using Lists;




ArrayList list=new ArrayList();



for(int i=0; i<2; i++)
{
    list.AddValuesToTheEnd(-5);
    list.AddValuesToTheEnd(-6);
    list.AddValuesToTheEnd(-7);
    list.AddValuesToTheEnd(-8);
    list.AddValuesToTheEnd(-9);
    list.AddValuesToTheEnd(-10);

}

list.Write();


list.DeleteTHeEndNElements(-2);
list.Write();

Console.WriteLine();