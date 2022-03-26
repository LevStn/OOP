using NUnit.Framework;
using System.Collections;

namespace Lists.Tests.ArrayListsTestSources
{
    public class ReverseTestsSource : IEnumerable
    {
    
        public IEnumerator GetEnumerator()
        {

            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expected = new ArrayList(new int[] { 5, 4, 3, 2, 1 });

            yield return new object[] { list, expected };



            list = new ArrayList(new int[] { });
            expected = new ArrayList(new int[] { });

            yield return new object[] { list, expected };



            list = new ArrayList(new int[] { 1 });
            expected = new ArrayList(new int[] { 1 });

            yield return new object[] { list, expected };



            list = new ArrayList(new int[] { -20, -8 });
            expected = new ArrayList(new int[] { -8, -20 });

            yield return new object[] { list, expected };



            list = new ArrayList(new int[] { 0, 0, 0 });
            expected = new ArrayList(new int[] { 0, 0, 0 });

            yield return new object[] { list, expected };
        }


    }
}
