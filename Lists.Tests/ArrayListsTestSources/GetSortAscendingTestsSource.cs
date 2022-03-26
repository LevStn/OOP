using NUnit.Framework;
using System.Collections;


namespace Lists.Tests.ArrayListsTestSources
{
    internal class GetSortAscendingTestsSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            ArrayList list = new ArrayList (new int[] {1, 5, 4, 8});
            ArrayList expected = new ArrayList (new int[] { 1, 4, 5, 8 });


            yield return new object[] { list ,expected };




            list = new ArrayList(new int[] {  });
            expected = new ArrayList(new int[] {  });


            yield return new object[] { list, expected };



            list = new ArrayList(new int[] { 1 });
            expected = new ArrayList(new int[] { 1 });


            yield return new object[] { list, expected };



            list = new ArrayList(new int[] { -1, -20, -5, 5 });
            expected = new ArrayList(new int[] { -20, -5, -1, 5 });


            yield return new object[] { list, expected };



            list = new ArrayList(new int[] { 0, 0, 0 });
            expected = new ArrayList(new int[] { 0, 0, 0 });


            yield return new object[] { list, expected };
        }
    }
}
