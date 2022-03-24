using NUnit.Framework;
using System.Collections;

namespace Lists.Tests.ArrayListsTestSources
{
    public class DeleteTHeBegineNElementsTestsSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            int number = 0;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expected = new ArrayList(new int[] { 1, 2, 3, 4, 5 });

            yield return new object[] { number, list, expected };



            number = 1;
            list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            expected = new ArrayList(new int[] { 2, 3, 4,5 });

            yield return new object[] { number, list, expected };


            number = 2;
            list = new ArrayList(new int[] { -1, -2, -3, -4, -5 });
            expected = new ArrayList(new int[] { -3, -4, -5 });

            yield return new object[] { number, list, expected };


            number = 4;
            list = new ArrayList(new int[] { -1, -2, -33, 50, -5, 8, 1, 2 });
            expected = new ArrayList(new int[] { -5, 8, 1, 2 });

            yield return new object[] { number, list, expected };
        }

    }

    public class NegativeDeleteTHeBegineNElementsTestsSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {

            int number = 20;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });

            yield return new object[] { number, list };



            number = 1;
            list = new ArrayList(new int[] { });

            yield return new object[] { number, list };


            number = -1;
            list = new ArrayList(new int[] { 1 });

            yield return new object[] { number, list };


            number = -20;
            list = new ArrayList(new int[] { -1, -2, -33, 50, -5, 8, 1, 2 });

            yield return new object[] { number, list };
        }




    }
}
