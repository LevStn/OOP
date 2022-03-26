using Lists;




ArrayList list=new ArrayList();



for(int i=0; i<10; i++)
{
    list.AddValuesToTheEnd(5);

    


}

list.Write();


ArrayList newList=new ArrayList(new int[] { 1, 1, 1, 1,8,9,10,1,2,2 });

list.AddListToEnd(newList);
list.Write();
