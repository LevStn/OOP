using NUnit.Framework;
using System.Collections;

namespace Lists.Tests.LinkedListsTestsSources
{
    public class AddListToIndexTestsSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 1;
            LinkedList list = new LinkedList(new int[] { 1, 2, 3 });
            LinkedList newList = new LinkedList(new int[] { 4, 5 });
            LinkedList expected = new LinkedList(new int[] { 1, 4, 5, 2, 3 });

            yield return new object[] { index, list, newList, expected };



            index = 2;
            list = new LinkedList(new int[] { 1, 2, 3, 4 });
            newList = new LinkedList(new int[] { 4, 5, 6 });
            expected = new LinkedList(new int[] { 1, 2, 4, 5, 6, 3, 4 });

            yield return new object[] { index, list, newList, expected };



            index = 3;
            list = new LinkedList(new int[] { 1, 2, 3, 4 });
            newList = new LinkedList(new int[] { 4, 5, 6, 3 });
            expected = new LinkedList(new int[] { 1, 2, 3, 4, 5, 6, 3, 4 });

            yield return new object[] { index, list, newList, expected };



            index = 0;
            list = new LinkedList(new int[] { 1, 2, 3, 4 });
            newList = new LinkedList(new int[] { 4, 5, 6, 3 });
            expected = new LinkedList(new int[] { 4, 5, 6, 3, 1, 2, 3, 4 });

            yield return new object[] { index, list, newList, expected };



            index = 2;
            list = new LinkedList(new int[] { 1, 2 });
            newList = new LinkedList(new int[] { 4, 5, 6, 3 });
            expected = new LinkedList(new int[] { 1, 2, 4, 5, 6, 3 });

            yield return new object[] { index, list, newList, expected };


            index = 1;
            list = new LinkedList(new int[] { -4, -5, -6, 3 });
            newList = new LinkedList(new int[] { 1 });
            expected = new LinkedList(new int[] { -4, 1, - 5, -6, 3 });

            yield return new object[] { index, list, newList, expected };


        }



    }



    
}
namespace Lists.Tests.LinkedListsTestsSources
{
    public class NegativeFirstAddListToBeginTestsSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = -1;  
            LinkedList list = new LinkedList(new int[] { 1, 2, 3 });
            LinkedList newList = new LinkedList(new int[] { 1, 2, 3 });

            yield return new object[] { index, list, newList };


            index = 10;
            list = new LinkedList(new int[] { 1, 2, 3 });
            newList = new LinkedList(new int[] { 1, 2, 3 });

            yield return new object[] { index, list, newList };
        }
    }
    public class NegativeSecondAddListToBeginTestsSou : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int index = 0;
            LinkedList list = new LinkedList(new int[] { 1, 2, 3 });
            LinkedList newList = null;

            yield return new object[] { index, list, newList };

            index = 1;
            list = null;
            newList = new LinkedList(new int[] { 1, 2, 3 });

            yield return new object[] { index, list, newList };
        }
    }


}