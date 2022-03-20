using Lists;




ArrayList list=new ArrayList();


for( int i=0; i<=5; i++)
{
    list.AddValuesToTheEnd(i);
    list.Write();

}

list.DeleteBegin();
list.Write();

