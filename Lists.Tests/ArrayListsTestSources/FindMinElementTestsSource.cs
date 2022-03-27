using NUnit.Framework;
using System.Collections;


namespace Lists.Tests.ArrayListsTestSources
{
    public class FindMinElementTestsSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            ArrayList list = new ArrayList(new int[] {1, 2, 3, 4});
            int expected = 1;

            yield return new object[] {list, expected};



            list = new ArrayList(new int[] { -1, -2, -3, -4 });
            expected = -4;

            yield return new object[] { list, expected };



            list = new ArrayList(new int[] { -1 });
            expected = -1;

            yield return new object[] { list, expected };



            list = new ArrayList(new int[] { 0, 0, 0, 0 });
            expected = 0;

            yield return new object[] { list, expected };

        }

    }


    public class NegativeFindMinElementTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {
            ArrayList list = new ArrayList(new int[] { });

            yield return new object[] { list };

        }
    }
}
