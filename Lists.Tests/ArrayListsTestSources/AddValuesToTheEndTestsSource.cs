using NUnit.Framework;
using System.Collections;
using Lists.Tests.ArrayListsTestSources;


namespace Lists.Tests.ArrayListsTestSources
{
    internal class AddValuesToTheEndTestsSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            int value = 3;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expected = new ArrayList(new int[] { 1, 2, 3, 4, 5, 3 });
            
            yield return new object[] {  value,  list,  expected };


            value = -3;
            list = new ArrayList(new int[] { 1 });
            expected = new ArrayList(new int[] { 1, -3 });

            yield return new object[] { value, list, expected };


            value = 0;
            list = new ArrayList(new int[] { 0, 0, 0 });
            expected = new ArrayList(new int[] { 0, 0, 0, 0 });

            yield return new object[] { value, list, expected };


            value = 5;
            list = new ArrayList(new int[] {  });
            expected = new ArrayList(new int[] { 5 });

            yield return new object[] { value, list, expected };


            value = -3;
            list = new ArrayList(new int[] { -5, -7, -9, -7 });
            expected = new ArrayList(new int[] { -5, -7, -9, -7, -3 });

            yield return new object[] { value, list, expected };
        }
    }
}
