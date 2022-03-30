using NUnit.Framework;
using System.Collections;



namespace Lists.Tests.LinkedListsTestsSources
{
    public class DeleteByValueFirstTestsSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            int value = 5;
            LinkedList list = new LinkedList(new int[] {1, 2, 3, 4, 5});
            LinkedList expectedList = new LinkedList(new int[] { 1, 2, 3, 4});
            int expectedValue = 4;

            yield return new object[] { value,  list,  expectedList,  expectedValue };


            value = 50;
            list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            expectedList = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            expectedValue = -1;

            yield return new object[] { value, list, expectedList, expectedValue };


            value = 0;
            list = new LinkedList(new int[] { 0 });
            expectedList = new LinkedList(new int[] {  });
            expectedValue = 0;

            yield return new object[] { value, list, expectedList, expectedValue };



            value = -2;
            list = new LinkedList(new int[] { 1, 2, -2, 3 });
            expectedList = new LinkedList(new int[] { 1, 2, 3 });
            expectedValue = 2;

            yield return new object[] { value, list, expectedList, expectedValue };



            value = -2;
            list = new LinkedList(new int[] { 1, 2, -2, 3, -2 });
            expectedList = new LinkedList(new int[] { 1, 2, 3, -2 });
            expectedValue = 2;

            yield return new object[] { value, list, expectedList, expectedValue };



            value = 21;
            list = new LinkedList(new int[] { 1, 21, -211, 31, -20 });
            expectedList = new LinkedList(new int[] { 1, -211, 31, -20 });
            expectedValue = 1;

            yield return new object[] { value, list, expectedList, expectedValue };
        }
    }
}
