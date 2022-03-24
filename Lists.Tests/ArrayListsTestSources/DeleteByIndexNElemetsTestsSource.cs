using NUnit.Framework;
using System.Collections;



namespace Lists.Tests.ArrayListsTestSources
{
    internal class DeleteByIndexNElemetsTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {

            int index = 0;
            int number = 0;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expected = new ArrayList(new int[] { 1, 2, 3, 4, 5 });

            yield return new object[] {index, number, list, expected };



            index = 1;
            number = 1;
            list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            expected = new ArrayList(new int[] { 1, 3, 4, 5 });

            yield return new object[] { index, number, list, expected };



            index = 0;
            number = 2;
            list = new ArrayList(new int[] { -1, -2, -3, -4, -5 });
            expected = new ArrayList(new int[] { -3, -4, -5 });

            yield return new object[] { index, number, list, expected };



            index = 2;
            number = 2;
            list = new ArrayList(new int[] { -1, -2, -33, 50, -5, 8, 1, 2 });
            expected = new ArrayList(new int[] { -1, -2, -5, 8, 1, 2 });

            yield return new object[] { index, number, list, expected };
        }

    }

    public class NegativeDeleteByIndexNElemetsTestsSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            int index = 20;
            int number = 1;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });

            yield return new object[] { index, number, list };



            index = -1;
            number = 1;
            list = new ArrayList(new int[] { });

            yield return new object[] { index, number, list };



            index = 0;
            number = -1;
            list = new ArrayList(new int[] { 1 });

            yield return new object[] { index, number, list };



            index = 1;
            number = 20;
            list = new ArrayList(new int[] { -1, -2, -33, 50, -5, 8, 1, 2 });

            yield return new object[] { index, number, list };


            index = 1;
            number = 0;
            list = new ArrayList(new int[] {  });

            yield return new object[] { index, number, list };



            index = 0;
            number = 1;
            list = new ArrayList(new int[] { });

            yield return new object[] { index, number, list };



            index = 2;
            number = 1;
            list = new ArrayList(new int[] {1, 2 });

            yield return new object[] { index, number, list };
        }

    }
}
