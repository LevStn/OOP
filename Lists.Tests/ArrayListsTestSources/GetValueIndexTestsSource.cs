using NUnit.Framework;
using System.Collections;

namespace Lists.Tests.ArrayListsTestSources
{
    public class GetValueIndexTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {

            int index = 0;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            int expected =1 ;

            yield return new object[] { index, list, expected };



            index = 4;
            list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            expected = 5;

            yield return new object[] { index, list, expected };
        }


    }


    public class NegativeGetValueIndexTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {

            int index = 0;
            ArrayList list = new ArrayList(new int[] {  });
            
            yield return new object[] { index, list };



            index = 5;
            list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            
            yield return new object[] { index, list};


            index = -5;
            list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });

            yield return new object[] { index, list };
        }


    }
}
