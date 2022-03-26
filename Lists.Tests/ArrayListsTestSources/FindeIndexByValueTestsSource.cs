using NUnit.Framework;
using System.Collections;

namespace Lists.Tests.ArrayListsTestSources
{
    public class FindeIndexByValueTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {

            int value = 0; ;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            int expected = -1;

            yield return new object[] {  value,  list, expected };



            value = 2; ;
            list = new ArrayList(new int[] { 1, 2, 3, 4, 5, 2 });
            expected = 1;

            yield return new object[] { value, list, expected };


            value = 0; ;
            list = new ArrayList(new int[] { 5 });
            expected = -1;

            yield return new object[] { value, list, expected };



            value = 5; ;
            list = new ArrayList(new int[] { 5 });
            expected = 0;

            yield return new object[] { value, list, expected };



            value = 5; 
            list = new ArrayList(new int[] {  });
            expected = -1;

            yield return new object[] { value, list, expected };



            value = -6;
            list = new ArrayList(new int[] { -5, -10, 20, 50, -6, -11 });
            expected = 4;

            yield return new object[] { value, list, expected };
        }
    }
}
