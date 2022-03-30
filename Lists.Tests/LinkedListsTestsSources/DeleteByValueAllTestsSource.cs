using NUnit.Framework;
using System.Collections;

namespace Lists.Tests.LinkedListsTestsSources
{
    public class DeleteByValueAllTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {

            int value = 5;
            LinkedList list = new LinkedList(new int[] { 1, 5, 3, 4, 5, 8, 5  });
            LinkedList expectedList = new LinkedList(new int[] { 1, 3, 4, 8 });
            int expectedCount = 3;

            yield return new object[] { value, list, expectedList, expectedCount };


            value = 50;
            list = new LinkedList(new int[] { 1, 2, 50, 4, 5 });
            expectedList = new LinkedList(new int[] { 1, 2, 4, 5 });
            expectedCount = 1;

            yield return new object[] { value, list, expectedList, expectedCount };


            value = 0;
            list = new LinkedList(new int[] { 0 });
            expectedList = new LinkedList(new int[] { });
            expectedCount = 1;

            yield return new object[] { value, list, expectedList, expectedCount };



            value = -2;
            list = new LinkedList(new int[] { -2, -2, -2, -2 });
            expectedList = new LinkedList(new int[] {  });
            expectedCount = 4;

            yield return new object[] { value, list, expectedList, expectedCount };



            value = 5;
            list = new LinkedList(new int[] { 1, 2, -2, 3, -2 });
            expectedList = new LinkedList(new int[] { 1, 2, -2, 3, -2 });
            expectedCount = 0;

            yield return new object[] { value, list, expectedList, expectedCount };



            value = 21;
            list = new LinkedList(new int[] { 1, 2, -211, 31, 21 });
            expectedList = new LinkedList(new int[] { 1, 2, -211, 31 });
            expectedCount = 1;

            yield return new object[] { value, list, expectedList, expectedCount };



            value = 1;
            list = new LinkedList(new int[] { 1, 2, -211, 31, 21 });
            expectedList = new LinkedList(new int[] { 2, -211, 31, 21 });
            expectedCount = 1;

            yield return new object[] { value, list, expectedList, expectedCount };
        }
    }
}
