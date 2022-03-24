using NUnit.Framework;
using System.Collections;

namespace Lists.Tests.ArrayListsTestSources
{
    public class AddValuesToIndexTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {

            int value = 3;
            int index = 0;
            ArrayList list = new ArrayList(new int[] { 0, 1, 2, 3, 4, 5 });
            ArrayList expected = new ArrayList(new int[] {3, 0, 1, 2, 3, 4, 5 });
           
            yield return new object[] { value, index, list, expected };



            value = -3;
            index = 1;
            list = new ArrayList(new int[] { 0, 1, 2, 3, 4, 5 });
            expected = new ArrayList(new int[] { 0, -3, 1, 2, 3, 4, 5 });

            yield return new object[] { value, index, list, expected };



            value = 0;
            index = 1;
            list = new ArrayList(new int[] { 0 });
            expected = new ArrayList(new int[] { 0, 0 });

            yield return new object[] { value, index, list, expected };



            value = 55;
            index = 0;
            list = new ArrayList(new int[] {  });
            expected = new ArrayList(new int[] { 55 });

            yield return new object[] { value, index, list, expected };



            value = -55;
            index = 5;
            list = new ArrayList(new int[] {-1, -9, 4, -8, -10, -80, -99 });
            expected = new ArrayList(new int[] { -1, -9, 4, -8, -10, -55, -80, -99 });

            yield return new object[] { value, index, list, expected };




        }

    }

}

