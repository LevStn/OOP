using NUnit.Framework;
using System.Collections;

namespace Lists.Tests.ArrayListsTestSources
{
    public class ChangesByIndexTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {

            int index = 0;
            int? value = -1;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expectedList= new ArrayList(new int[] { -1, 2, 3, 4, 5 });
            int expectedOldNummb = 1;


            yield return new object[] { index,  value,  list, expectedList, expectedOldNummb };



            index = 3;
            value = 55;
            list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            expectedList = new ArrayList(new int[] { 1, 2, 3, 55, 5 });
            expectedOldNummb = 4;


            yield return new object[] { index, value, list, expectedList, expectedOldNummb };



            index = 0;
            value = 1;
            list = new ArrayList(new int[] { 10 });
            expectedList = new ArrayList(new int[] { 1 });
            expectedOldNummb =10 ;


            yield return new object[] { index, value, list, expectedList, expectedOldNummb };



            index = 1;
            value = 0;
            list = new ArrayList(new int[] { 10, 0 });
            expectedList = new ArrayList(new int[] { 10, 0 });
            expectedOldNummb = 0;


            yield return new object[] { index, value, list, expectedList, expectedOldNummb };
        }
    }



    public class NegativeChangesByIndexTestsSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 1;
            int value = 1;
            ArrayList list = new ArrayList(new int[] {  });


            yield return new object[] { index, value, list };



            index = 4;
            value = 100;
            list = new ArrayList(new int[] { 1, 2, 3 });


            yield return new object[] { index, value, list };


            index = -4;
            value = -100;
            list = new ArrayList(new int[] { -1, -2, -3 });


            yield return new object[] { index, value, list };
        }
    }
}
