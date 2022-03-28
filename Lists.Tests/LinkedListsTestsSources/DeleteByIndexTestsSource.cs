using NUnit.Framework;
using System.Collections;

namespace Lists.Tests.LinkedListsTestsSources
{
    public class DeleteByIndexTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {

            int index = 0;
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList expected = new LinkedList(new int[] { 2, 3, 4, 5 });

            yield return new object[] {  index, list, expected };


            index = 2;
            list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            expected = new LinkedList(new int[] { 1, 2, 4, 5 });

            yield return new object[] { index, list, expected };


            index = 4;
            list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            expected = new LinkedList(new int[] { 1, 2, 3, 4, });

            yield return new object[] { index, list, expected };




            index = 1;
            list = new LinkedList(new int[] { -1, -2, -3 });
            expected = new LinkedList(new int[] {-1,-3 });

            yield return new object[] { index, list, expected };


            index = 0;
            list = new LinkedList(new int[] { -1});
            expected = new LinkedList(new int[] {  });

            yield return new object[] { index, list, expected };


            int? indexNull = null;
            list = new LinkedList(new int[] { });
            expected = new LinkedList(new int[] {  });

            yield return new object[] { indexNull, list, expected };
        }

    }


    public class NegativeDeleteByIndexTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {

            int index = -1;
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });


            yield return new object[] { index, list };


            index = 6;
            list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });


            yield return new object[] { index, list };






        }

    }



}

