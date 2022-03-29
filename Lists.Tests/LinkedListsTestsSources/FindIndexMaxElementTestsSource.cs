using NUnit.Framework;
using System.Collections;

namespace Lists.Tests.LinkedListsTestsSources
{
    public class FindIndexMaxElementTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {


            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            int expected = 4;

            yield return new object[] { list, expected };


            list = new LinkedList(new int[] { 10, 2, -30, 4, 5 });
            expected = 0;

            yield return new object[] { list, expected };


            list = new LinkedList(new int[] { 1, 2, 30, 4, 0 });
            expected = 2;

            yield return new object[] { list, expected };



            list = new LinkedList(new int[] { 10, 2, 3, 40, 5 });
            expected = 3;

            yield return new object[] { list, expected };



            list = new LinkedList(new int[] { -2, -1, -30 });
            expected = 1;

            yield return new object[] { list, expected };


            list = new LinkedList(new int[] { 1 });
            expected = 0;

            yield return new object[] { list, expected };

        }
    }

    public class NegativeFindIndexMaxElementTestsSources : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {


            LinkedList list = new LinkedList(new int[] { });


            yield return new object[] { list };


        }
    }
}

