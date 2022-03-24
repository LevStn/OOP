using NUnit.Framework;
using System.Collections;



namespace Lists.Tests.ArrayListsTestSources
{
    public class DeleteByIndexTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {

            int index = 0;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4});
            ArrayList expectedList = new ArrayList(new int [] {2, 3, 4});
            int expectedDeleteNumb = 1;

            yield return new object[] { index, list, expectedList, expectedDeleteNumb };



            index = 3;
            list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            expectedList = new ArrayList(new int[] { 1, 2, 3, 5 });
            expectedDeleteNumb = 4;

            yield return new object[] { index, list, expectedList, expectedDeleteNumb };



            index = 0;
            list = new ArrayList(new int[] { 1 });
            expectedList = new ArrayList(new int[] { });
            expectedDeleteNumb = 1;

            yield return new object[] { index, list, expectedList, expectedDeleteNumb };



            index = 5;
            list = new ArrayList(new int[] { -1, -20, -34, -44, -5, -1, -66 });
            expectedList = new ArrayList(new int[] { -1, -20, -34, -44, -5, -66 });
            expectedDeleteNumb = -1;

            yield return new object[] { index, list, expectedList, expectedDeleteNumb };


            index = 2;
            list = new ArrayList(new int[] { 0, 0, 0, 0, 0, 0, 0 });
            expectedList = new ArrayList(new int[] { 0, 0, 0, 0, 0, 0 });
            expectedDeleteNumb = 0;

            yield return new object[] { index, list, expectedList, expectedDeleteNumb };

        }

    }


    public class NegativeDeleteByIndexTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {

            int index = -1;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4 });
           
            yield return new object[] { index, list };



            index = 50;
            list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
           
            yield return new object[] { index, list };



            index = 1;
            list = new ArrayList(new int[] { 1 });
 
            yield return new object[] { index, list };



            index = 1;
            list = new ArrayList(new int[] { -1 });

            yield return new object[] { index, list };


            index = 0;
            list = new ArrayList(new int[] {  });

            yield return new object[] { index, list };

        }

    }
}
