using Lists;




ArrayList list=new ArrayList();



for(int i=0; i<1; i++)
{
    list.AddValuesToTheEnd(5);
    





}

list.Write();


ArrayList newList=new ArrayList(new int[] { 1 });

list.AddListToIndex(newList, 3);
list.Write();
