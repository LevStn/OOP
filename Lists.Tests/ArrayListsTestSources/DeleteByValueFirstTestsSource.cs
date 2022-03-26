using NUnit.Framework;
using System.Collections;

namespace Lists.Tests.ArrayListsTestSources
{
    internal class DeleteByValueFirstTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {

            int value = 0;
            ArrayList list = new ArrayList(new int[] {0, 1, 2, 3});
            ArrayList expectedList = new ArrayList(new int[] { 1, 2, 3 });
            int expectedIndex = 0;

            yield return new object[] {  value, list, expectedIndex, expectedList };



            value = 3;
            list = new ArrayList(new int[] { 0, 1, 2, 3 });
            expectedList = new ArrayList(new int[] { 0, 1, 2 });
            expectedIndex = 3;

            yield return new object[] { value, list, expectedIndex, expectedList };



            value = 3;
            list = new ArrayList(new int[] {  });
            expectedList = new ArrayList(new int[] {  });
            expectedIndex = -1;

            yield return new object[] { value, list, expectedIndex, expectedList };



            value = 5;
            list = new ArrayList(new int[] { 0, 1, 2, 3 });
            expectedList = new ArrayList(new int[] { 0, 1, 2, 3 });
            expectedIndex = -1;

            yield return new object[] { value, list, expectedIndex, expectedList };



            value = 1;
            list = new ArrayList(new int[] {1});
            expectedList = new ArrayList(new int[] { });
            expectedIndex = 0;

            yield return new object[] { value, list, expectedIndex, expectedList };



            value = 1;
            list = new ArrayList(new int[] {1, 2, 3, 1 });
            expectedList = new ArrayList(new int[] { 2, 3, 1 });
            expectedIndex = 0;

            yield return new object[] { value, list, expectedIndex, expectedList };




            value = -1;
            list = new ArrayList(new int[] { -2, -3, -1 });
            expectedList = new ArrayList(new int[] { -2, -3 });
            expectedIndex = 2;

            yield return new object[] { value, list, expectedIndex, expectedList };
        }
    }
}
