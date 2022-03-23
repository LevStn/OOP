using Lists;




ArrayList list=new ArrayList();

list.AddValuesToTheEnd(3);

for(int i=0; i<5; i++)
{
    list.AddValuesToTheEnd(5);

}
list.AddValuesToTheEnd(65);

list.Write();


list.DeleteByValueAll(3);
list.Write();

