using NUnit.Framework;
using System.Collections;

namespace Lists.Tests.LinkedListsTestsSources
{
    public class GetValueByIndexTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {

            int index = 0;
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            int expected = 1;

            yield return new object[] { index, list, expected };

            index = 4;
            list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            expected = 5;

            yield return new object[] { index, list, expected };


            index = 2;
            list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            expected = 3;


            index = 1;
            list = new LinkedList(new int[] { 2 });
            expected = -1;

            yield return new object[] { index, list, expected };


            index = 100;
            list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            expected = -1;

            yield return new object[] { index, list, expected };


            index = 1;
            list = new LinkedList(new int[] { -2,-10 });
            expected = -10;

            yield return new object[] { index, list, expected };

            index = 1;
            list = new LinkedList(new int[] { });
            expected = -1;

            yield return new object[] { index, list, expected };



            index = 0;
            list = new LinkedList(new int[] { });
            expected = -1;

            yield return new object[] { index, list, expected };
        }

    }

}

