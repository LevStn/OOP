using NUnit.Framework;
using System.Collections;

namespace Lists.Tests.LinkedListsTestsSources
{
    public class DeleteToBegineTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {


            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList expected = new LinkedList(new int[] { 2, 3, 4, 5 });

            yield return new object[] { list, expected };



            list = new LinkedList(new int[] { 1 });
            expected = new LinkedList(new int[] { });

            yield return new object[] { list, expected };


            list = new LinkedList(new int[] { -1, -2 });
            expected = new LinkedList(new int[] { -2 });

            yield return new object[] { list, expected };



            list = new LinkedList(new int[] { });
            expected = new LinkedList(new int[] { });

            yield return new object[] { list, expected };




        }

    }



}

