using NUnit.Framework;
using System.Collections;


namespace Lists.Tests.ArrayListsTestSources
{
    public class FindMaxElementTestsSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            ArrayList list = new ArrayList(new int[] { 1 });
            int expected = 1;
            yield return new object[] { list, expected };



            list = new ArrayList(new int[] { 1, 2, 3, 40, 5, 10 });
            expected = 40;
            yield return new object[] { list, expected };



            list = new ArrayList(new int[] { -10, -20, -1, -5 });
            expected = -1;
            yield return new object[] { list, expected };




            list = new ArrayList(new int[] { -1, -10, 5, 6 });
            expected = 6;
            yield return new object[] { list, expected };



            list = new ArrayList(new int[] { 0, 0, 0 });
            expected = 0;
            yield return new object[] { list, expected };



            list = new ArrayList(new int[] { 0 });
            expected = 0;
            yield return new object[] { list, expected };

        }
    }


    public class NegativeFindeMaxElementTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] {});

            yield return new object[] { list };

        }
    }
}