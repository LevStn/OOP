using NUnit.Framework;
using System.Collections;

namespace Lists.Tests.LinkedListsTestsSources
{
    public class AddListToBeginTestsSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            LinkedList list = new LinkedList(new int[] { 1, 2, 3 });
            LinkedList newList = new LinkedList(new int[] { 4, 5 });
            LinkedList expected = new LinkedList(new int[] { 4, 5, 1, 2, 3 });

            yield return new object[] { list, newList, expected };



            list = new LinkedList(new int[] { 1 });
            newList = new LinkedList(new int[] { 0 });
            expected = new LinkedList(new int[] {  0, 1 });

            yield return new object[] { list, newList, expected };



            list = new LinkedList(new int[] { -1, -2, -3 });
            newList = new LinkedList(new int[] { -2 });
            expected = new LinkedList(new int[] { -2, -1, -2, -3 });

            yield return new object[] { list, newList, expected };



            list = new LinkedList(new int[] { -10, 22, 300 });
            newList = new LinkedList(new int[] { -1, 0, 500 });
            expected = new LinkedList(new int[] { -1, 0, 500, -10, 22, 300 });

            yield return new object[] { list, newList, expected };



        }
    }

    public class NegativeAddListToBeginTestsSource : IEnumerable
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
