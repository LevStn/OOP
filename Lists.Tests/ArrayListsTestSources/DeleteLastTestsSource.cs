using NUnit.Framework;
using System.Collections;

namespace Lists.Tests.ArrayListsTestSources
{
    public  class DeleteLastTestsSource : IEnumerable
    {

        public  IEnumerator GetEnumerator()
        {

            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expected = new ArrayList(new int[] { 1, 2, 3, 4 });

            yield return new object [] {list,  expected };



            list = new ArrayList(new int[] { 1 });
            expected = new ArrayList(new int[] {  });

            yield return new object[] { list, expected };



            list = new ArrayList(new int[] { -55, -10, -5, 10 });
            expected = new ArrayList(new int[] { -55, -10, -5 });

            yield return new object[] { list, expected };



            list = new ArrayList(new int[] { 0, 0, 0, 0 });
            expected = new ArrayList(new int[] { 0, 0, 0 });

            yield return new object[] { list, expected };



        }
    }
}
