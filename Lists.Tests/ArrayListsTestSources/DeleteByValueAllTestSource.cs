using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lists.Tests.ArrayListsTestSources
{
    public class DeleteByValueAllTests : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 3;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 5 });
            ArrayList expectedList = new ArrayList(new int[] { 1, 2, 4, 5 });
            int expectedNumbers = 1;

            yield return new object[] { value, list, expectedList, expectedNumbers };



            value = 2;
            list = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            expectedList = new ArrayList(new int[] { 1, 5 });
            expectedNumbers = 3;

            yield return new object[] { value, list, expectedList, expectedNumbers };



            value = 0;
            list = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            expectedList = new ArrayList(new int[] { 1, 2, 2, 2, 5 });
            expectedNumbers = 3;

            yield return new object[] { value, list, expectedList, expectedNumbers };



            value = 6;
            list = new ArrayList(new int[] { 1 });
            expectedList = new ArrayList(new int[] { 1 });
            expectedNumbers = 0;

            yield return new object[] { value, list, expectedList, expectedNumbers };



            value = 0;
            list = new ArrayList(new int[] { });
            expectedList = new ArrayList(new int[] { });
            expectedNumbers = 3;

            yield return new object[] { value, list, expectedList, expectedNumbers };



            value = -2;
            list = new ArrayList(new int[] { -1, -2, -2, -2, -5 });
            expectedList = new ArrayList(new int[] { -1, -5 });
            expectedNumbers = 3;

            yield return new object[] { value, list, expectedList, expectedNumbers };
        }
    }
}



