using NUnit.Framework;
using System.Collections;

namespace Lists.Tests.LinkedListsTestsSources
{
    public class SortAscendingTestsSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            LinkedList list = new LinkedList(new int[] { 5, 2, 1 });
            LinkedList expectedList = new LinkedList(new int[] { 1, 2, 5 });

            yield return new object[] { list, expectedList };



            list = new LinkedList(new int[] {  });
            expectedList = new LinkedList(new int[] {  });

            yield return new object[] { list, expectedList };



            list = new LinkedList(new int[] { 5 });
            expectedList = new LinkedList(new int[] { 5 });

            yield return new object[] { list, expectedList };



            list = new LinkedList(new int[] { 5, 1, 2,  4 });
            expectedList = new LinkedList(new int[] { 1, 2, 4, 5 });

            yield return new object[] { list, expectedList };



            list = new LinkedList(new int[] { 5, 6, 2, 4 });
            expectedList = new LinkedList(new int[] {  2, 4, 5, 6 });

            yield return new object[] { list, expectedList };



            list = new LinkedList(new int[] { -5, -60, -2, -40 });
            expectedList = new LinkedList(new int[] { -60, -40, -5, -2 });

            yield return new object[] { list, expectedList };



            list = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });
            expectedList = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });

            yield return new object[] { list, expectedList };


            list = new LinkedList(new int[] { 6, 5, 4, 3, 2, 1  });
            expectedList = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6 });

            yield return new object[] { list, expectedList };




            list = new LinkedList(new int[] { 6, 5, -4, 4, 2, 1 });
            expectedList = new LinkedList(new int[] { -4, 1, 2, 4, 5, 6 });

            yield return new object[] { list, expectedList };

        }
    }
}
