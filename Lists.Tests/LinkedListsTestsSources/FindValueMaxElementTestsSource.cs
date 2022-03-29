using NUnit.Framework;
using System.Collections;

namespace Lists.Tests.LinkedListsTestsSources
{
    public class FindValueMaxElementTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {


            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            int expected = 5;

            yield return new object[] { list, expected };


            list = new LinkedList(new int[] { 1, 2, 30, 4, 5 });
            expected = 30;

            yield return new object[] { list, expected };


            list = new LinkedList(new int[] { 1, 2, 30, 4, 5 });
            expected = 30;

            yield return new object[] { list, expected };



            list = new LinkedList(new int[] { 10, 2, 3, 4, 5 });
            expected = 10;

            yield return new object[] { list, expected };



            list = new LinkedList(new int[] { -2, -10 });
            expected = -2;

            yield return new object[] { list, expected };


            list = new LinkedList(new int[] { 1, 2, 30, 4, 50 });
            expected = 50;

            yield return new object[] { list, expected };

        }
    }

        public class NegativeFindValueMaxElementTestsSource : IEnumerable
        {

            public IEnumerator GetEnumerator()
            {


                LinkedList list = new LinkedList(new int[] { });


                yield return new object[] { list };


            }
        }
}

