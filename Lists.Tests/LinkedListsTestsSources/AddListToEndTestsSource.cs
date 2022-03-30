using NUnit.Framework;
using System.Collections;

namespace Lists.Tests.LinkedListsTestsSources
{
    public class AddListToEndTestsSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            
            LinkedList list = new LinkedList(new int[] { 1, 2, 3 });
            LinkedList newList = new LinkedList(new int[] { 4, 5 });
            LinkedList expected = new LinkedList(new int[] { 1, 2, 3, 4, 5 });

            yield return new object[] {  list,  newList,  expected };



            list = new LinkedList(new int[] { 1 });
            newList = new LinkedList(new int[] { 0 });
            expected = new LinkedList(new int[] { 1, 0 });

            yield return new object[] { list, newList, expected };



            list = new LinkedList(new int[] { -1, -2, -3 });
            newList = new LinkedList(new int[] { -2 });
            expected = new LinkedList(new int[] { -1, -2, -3, -2 });

            yield return new object[] { list, newList, expected };



            list = new LinkedList(new int[] { -10, 22, 300 });
            newList = new LinkedList(new int[] { -1, 0, 500 });
            expected = new LinkedList(new int[] { -10, 22, 300, - 1, 0, 500 });

            yield return new object[] { list, newList, expected };


          
        }
    }

    public class NegativeAddListToEndTestsSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList list = new LinkedList(new int[] { 1, 2, 3 });
            LinkedList newList = null;

            yield return new object[] { list, newList };


            list = null; 
            newList = new LinkedList(new int[] { 1, 2, 3 });

            yield return new object[] { list, newList };
        }
    }


}
