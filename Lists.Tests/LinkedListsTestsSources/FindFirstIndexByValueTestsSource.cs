using NUnit.Framework;
using System.Collections;

namespace Lists.Tests.LinkedListsTestsSources
{
    public class FindFirstIndexByValueTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {

            int value = 0;
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            int expected = -1;

            yield return new object[] { value, list, expected };

            value = 4;
            list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            expected = 3;

            yield return new object[] { value, list, expected };


            value = -4;
            list = new LinkedList(new int[] { -1, -2, -3, -4, -5 });
            expected = 3;

            yield return new object[] { value, list, expected };

            value = 10;
            list = new LinkedList(new int[] {  });
            expected = -1;

            yield return new object[] { value, list, expected };



            value = 3;
            list = new LinkedList(new int[] { 1, 2, 3 });
            expected = 2;

            yield return new object[] { value, list, expected };
        }

    }

}

