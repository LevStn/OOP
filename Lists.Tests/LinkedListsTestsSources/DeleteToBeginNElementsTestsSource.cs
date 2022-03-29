using NUnit.Framework;
using System.Collections;

namespace Lists.Tests.LinkedListsTestsSources
{
    public class DeleteToBeginNElementsTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {

            int number = 0;
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList expected = new LinkedList(new int[] { 1, 2, 3, 4, 5 });

            yield return new object[] { number, list, expected };


            number = 1;
            list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            expected = new LinkedList(new int[] { 2, 3, 4, 5 });

            yield return new object[] { number, list, expected };


            number = 2;
            list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            expected = new LinkedList(new int[] { 3, 4, 5, });

            yield return new object[] { number, list, expected };




            number = 1;
            list = new LinkedList(new int[] { -1 });
            expected = new LinkedList(new int[] { });

            yield return new object[] { number, list, expected };


            number = 2;
            list = new LinkedList(new int[] { -1, -5 });
            expected = new LinkedList(new int[] { });

            yield return new object[] { number, list, expected };


            int? numberNull = null;
            list = new LinkedList(new int[] { });
            expected = new LinkedList(new int[] { });

            yield return new object[] { numberNull, list, expected };
        }

    }


    public class NegativeDeleteToBeginNElementsTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {

            int number = 6;
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });


            yield return new object[] { number, list };


            number = 1;
            list = new LinkedList(new int[] { });


            yield return new object[] { number, list };


        }

    }

}

