using NUnit.Framework;
using System.Collections;

namespace Lists.Tests.ArrayListsTestSources
{
    public class AddValuesToTheBeginTestsSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            int value = 3;
            ArrayList list = new ArrayList(new int[] { 3, 1, 2, 3, 4, 5 });
            ArrayList expected = new ArrayList(new int[] {3, 3, 1, 2, 3, 4, 5 });

            yield return new object[] { value, list, expected };


            value = -3;
            list = new ArrayList(new int[] { 1 });
            expected = new ArrayList(new int[] { -3, 1 });

            yield return new object[] { value, list, expected };


            value = 0;
            list = new ArrayList(new int[] { 0, 0, 0 });
            expected = new ArrayList(new int[] { 0, 0, 0, 0 });

            yield return new object[] { value, list, expected };


            value = 5;
            list = new ArrayList(new int[] { });
            expected = new ArrayList(new int[] { 5 });

            yield return new object[] { value, list, expected };


            value = -3;
            list = new ArrayList(new int[] { -5, -7, -9, -7 });
            expected = new ArrayList(new int[] { -3, - 5, -7, -9, -7 });

            yield return new object[] { value, list, expected };


        }
    }
}
