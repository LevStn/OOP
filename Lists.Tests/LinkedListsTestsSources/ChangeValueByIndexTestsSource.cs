using NUnit.Framework;
using System.Collections;

namespace Lists.Tests.LinkedListsTestsSources
{
    public class ChangeValueByIndexTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {
            int value = 55;
            int index = 0;
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList expectedList = new LinkedList(new int[] { 55, 2, 3, 4, 5 });
            int  expectedOldNumb = 1;

            yield return new object[] { value, index, list,  expectedList, expectedOldNumb };



            value = -5;
            index = 4;
            list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            expectedList = new LinkedList(new int[] { 1, 2, 3, 4, -5 });
            expectedOldNumb = 5;

            yield return new object[] { value, index, list, expectedList, expectedOldNumb };



            value =10 ;
            index =0 ;
            list = new LinkedList(new int[] { 1 });
            expectedList = new LinkedList(new int[] { 10 });
            expectedOldNumb = 1;

            yield return new object[] { value, index, list, expectedList, expectedOldNumb };


            value = 11;
            index = 2;
            list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            expectedList = new LinkedList(new int[] { 1, 2, 11, 4, 5 });
            expectedOldNumb = 3;

            yield return new object[] { value, index, list, expectedList, expectedOldNumb };

        }

    }


    public class NegativeChangeValueByIndexTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {

            int value = 55;
            int index = 50;
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });

            yield return new object[] { value, index, list };


            value = 55;
            index = -1;
            list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });

            yield return new object[] { value, index, list };

            value = 55;
            index = 1;
            list = new LinkedList(new int[] { 1 });

            yield return new object[] { value, index, list };

        }

    }

}

