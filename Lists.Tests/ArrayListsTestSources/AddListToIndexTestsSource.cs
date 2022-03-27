using NUnit.Framework;
using System.Collections;

namespace Lists.Tests.ArrayListsTestSources
{
    public class AddListToIndexTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {


            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            ArrayList newList = new ArrayList(new int[] { 4, 5, 6, 7 });
            int index = 3;
            ArrayList expected = new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 4, 5, 6, 7, 8, 9 });

            yield return new object[] { list, newList, index, expected };



            list = new ArrayList(new int[] { 1 });
            newList = new ArrayList(new int[] { });
            index = 0;
            expected = new ArrayList(new int[] { 1 });

            yield return new object[] { list, newList, index, expected };



            list = new ArrayList(new int[] { 2 });
            newList = new ArrayList(new int[] { 1 });
            index = 0;
            expected = new ArrayList(new int[] { 1, 2 });

            yield return new object[] { list, newList, index, expected };


            list = new ArrayList(new int[] { 2 });
            newList = new ArrayList(new int[] { 1 });
            index = 1;
            expected = new ArrayList(new int[] { 2, 1 });

            yield return new object[] { list, newList, index, expected };



            list = new ArrayList(new int[] { 1, 2, 3 });
            newList = new ArrayList(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });
            index = 1;
            expected = new ArrayList(new int[] { 1, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 2, 3 });

            yield return new object[] { list, newList, index, expected };



            list = new ArrayList(new int[] { });
            newList = new ArrayList(new int[] { });
            index = 0;
            expected = new ArrayList(new int[] { });

            yield return new object[] { list, newList, index, expected };



            list = new ArrayList(new int[] { -1, -2, -3 });
            newList = new ArrayList(new int[] { -1, -2 });
            index = 3;
            expected = new ArrayList(new int[] { -1, -2, -3, -1, -2 });

            yield return new object[] { list, newList, index, expected };





        }
    }

    
    public class NegativeAddListToIndexTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {

            ArrayList list = new ArrayList(new int[] { 1, 2, 3 });
            ArrayList newList = null;
            int index = 2;

            yield return new object[] { list, newList, index };

        }

    }


    public class Negative2AddListToIndexTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {

            ArrayList list = new ArrayList(new int[] { 1, 2, 3 });
            ArrayList newList = new ArrayList(new int[] { 1, 2, 3 });
            int index = -2;

            yield return new object[] { list, newList, index };



            list = new ArrayList(new int[] { 1, 2, 3 });
            newList = new ArrayList(new int[] { 1, 2, 3 });
            index = 7;

            yield return new object[] { list, newList, index };


            list = new ArrayList(new int[] { 1 });
            newList = new ArrayList(new int[] { });
            index = 2;

            yield return new object[] { list, newList, index };



        }

    }
}


