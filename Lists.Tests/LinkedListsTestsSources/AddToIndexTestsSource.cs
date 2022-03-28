using NUnit.Framework;
using System.Collections;

namespace Lists.Tests.LinkedListsTestsSources
{
    public class AddToIndexTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {

            int value = 0;
            int index = 1;
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList expected = new LinkedList(new int[] { 1, 0, 2, 3, 4, 5 });

            yield return new object[] { value, index, list, expected };


            value = 55;
            index = 2;
            list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            expected = new LinkedList(new int[] { 1, 2, 55, 3, 4, 5 });

            yield return new object[] { value, index, list, expected };


            value = 55;
            index = 0;
            list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            expected = new LinkedList(new int[] {55, 1, 2, 3, 4, 5 });

            yield return new object[] { value, index, list, expected };


            value = -55;
            index = 0;
            list = new LinkedList(new int[] {  });
            expected = new LinkedList(new int[] { -55 });

            yield return new object[] { value, index, list, expected };


            value = -55;
            index = 3;
            list = new LinkedList(new int[] { 1, 2, 3 });
            expected = new LinkedList(new int[] { 1, 2, 3, -55 });

            yield return new object[] { value, index, list, expected };




        }

    }


    public class NegativeAddToIndexTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {

            int value = 0;
            int index = -1;
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            

            yield return new object[] { value, index, list };


            value = 55;
            index = 6;
            list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
           

            yield return new object[] { value, index, list};






        }

    }



}

