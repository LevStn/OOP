using NUnit.Framework;
using System.Collections;


namespace Lists.Tests.LinkedListsTestsSources
{
    public class ReverseTestsSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            LinkedList list = new LinkedList(new int[] {1, 2, 3});
            LinkedList expectedList = new LinkedList(new int[] {3, 2, 1});

            yield return new object[] { list, expectedList };



            list = new LinkedList(new int[] { 1 });
            expectedList = new LinkedList(new int[] { 1 });

            yield return new object[] { list, expectedList };



            list = new LinkedList(new int[] { 1, 5, 2, 1, 4, 6 });
            expectedList = new LinkedList(new int[] { 6, 4, 1, 2, 5, 1 });

            yield return new object[] { list, expectedList };



            list = new LinkedList(new int[] { 0, 0, 0, 0 });
            expectedList = new LinkedList(new int[] { 0, 0, 0, 0 });

            yield return new object[] { list, expectedList };



            list = new LinkedList(new int[] { -5, -5, -4, -3, 1 });
            expectedList = new LinkedList(new int[] { 1, -3, -4, -5, -5 });

            yield return new object[] { list, expectedList };



            list = new LinkedList(new int[] { });
            expectedList = new LinkedList(new int[] { });

            yield return new object[] { list, expectedList };
        }
    }
}
