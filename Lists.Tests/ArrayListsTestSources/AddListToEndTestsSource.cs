using NUnit.Framework;
using System.Collections;

namespace Lists.Tests.ArrayListsTestSources
{
    public class AddListToEndTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {

            
            ArrayList list = new ArrayList(new int[] { 1, 2, 3});
            ArrayList newList = new ArrayList(new int[] { 4, 5, 6, 7 });
            ArrayList expected = new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7 });

            yield return new object[] { list, newList,  expected };



            list = new ArrayList(new int[] { 1 });
            newList = new ArrayList(new int[] {  });
            expected = new ArrayList(new int[] { 1 });

            yield return new object[] { list, newList, expected };



            list = new ArrayList(new int[] {  });
            newList = new ArrayList(new int[] { 1 });
            expected = new ArrayList(new int[] { 1 });

            yield return new object[] { list, newList, expected };




            list = new ArrayList(new int[] { -11,0,55 });
            newList = new ArrayList(new int[] { 20,-5,-8 });
            expected = new ArrayList(new int[] { -11, 0, 55, 20, -5, -8 });

            yield return new object[] { list, newList, expected };



            list = new ArrayList(new int[] { 0, 0, 0 });
            newList = new ArrayList(new int[] { 0, 0, 0 });
            expected = new ArrayList(new int[] { 0, 0, 0, 0, 0, 0 });

            yield return new object[] { list, newList, expected };


            list = new ArrayList(new int[] {  });
            newList = new ArrayList(new int[] {  });
            expected = new ArrayList(new int[] { });

            yield return new object[] { list, newList, expected };




        }
    }

    public class NegativeAddListToEndTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {

            ArrayList list = new ArrayList(new int[] {1,2,3 });
            ArrayList newList = null;
            
            yield return new object[] { list, newList };



        }

    }

}

