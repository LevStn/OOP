using NUnit.Framework;
using System.Collections;

namespace Lists.Tests.ArrayListsTestSources
{
    internal class FindeIndexMaxElementTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { 1 });
            int expected = 0;
            yield return new object[] { list, expected };



            list = new ArrayList(new int[] { 1, 2, 3, 40, 5, 10 });
            expected = 3;
            yield return new object[] { list, expected };



            list = new ArrayList(new int[] { -10, -20, -1, -5 });
            expected = 2;
            yield return new object[] { list, expected };




            list = new ArrayList(new int[] { -1, -10, 5, 6 });
            expected = 3;
            yield return new object[] { list, expected };



            list = new ArrayList(new int[] { 0, 0, 0 });
            expected = 2;
            yield return new object[] { list, expected };



            list = new ArrayList(new int[] { 0 });
            expected = 0;
            yield return new object[] { list, expected };
        }
    }

    public class NegativeFindeIndexMaxElementTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { });

            yield return new object[] { list };

        }
    }
}
