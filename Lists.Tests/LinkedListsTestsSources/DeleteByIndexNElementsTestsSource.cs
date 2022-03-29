using NUnit.Framework;
using System.Collections;

namespace Lists.Tests.LinkedListsTestsSources
{
    public class DeleteByIndexNElementsTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {

            int number = 0;
            int index = 0;
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList expected = new LinkedList(new int[] { 1, 2, 3, 4, 5 });

            yield return new object[] { number, index, list, expected };


            number = 1;
            index = 1;
            list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            expected = new LinkedList(new int[] { 1, 3, 4, 5 });

            yield return new object[] { number, index, list, expected };



            number = 1;
            index = 4;
            list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            expected = new LinkedList(new int[] { 1, 2, 3, 4 });

            yield return new object[] { number, index, list, expected };


            number = 2;
            index = 1;
            list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            expected = new LinkedList(new int[] { 1, 4, 5, });

            yield return new object[] { number, index, list, expected };




            number = 2;
            index = 2;
            list = new LinkedList(new int[] { -1, -1, -3, -4, -5 });
            expected = new LinkedList(new int[] { -1, -1, -5 });

            yield return new object[] { number, index, list, expected };


            number = 2;
            index = 0;
            list = new LinkedList(new int[] { -1, -5 });
            expected = new LinkedList(new int[] { });

            yield return new object[] { number, index, list, expected };


            int? numberNull = null;
            int? indexNull = null;
            list = new LinkedList(new int[] { });
            expected = new LinkedList(new int[] { });

            yield return new object[] { numberNull, indexNull, list, expected };
        }

    }


    public class NegativeFirstDeleteByIndexNElementsTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {

            int number = 66;
            int index = 0;
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });


            yield return new object[] { number, index, list };


          

        }

    }

    public class NegativeSecondDeleteByIndexNElementsTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {
            int number = 1;
            int index = -1;
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });


            yield return new object[] { number, index, list };


            number = 1;
            index = 2;
            list = new LinkedList(new int[] { 1, 2});


            yield return new object[] { number, index, list };



            number = 4;
            index = 2;
            list = new LinkedList(new int[] { 1, 2 , 2, 3, 4 });


            yield return new object[] { number, index, list };



            number = 3;
            index = 3;
            list = new LinkedList(new int[] { 1, 2, 2, 3, 4 });


            yield return new object[] { number, index, list };

        }

    }

}

