﻿using NUnit.Framework;
using System.Collections;

namespace Lists.Tests.LinkedListsTestsSources
{
    public class AddToEndTestsSource : IEnumerable
    {

        public IEnumerator GetEnumerator()
        {

            int value = 0;
            LinkedList list = new LinkedList(new int[] { 1, 2, 3, 4, 5 });
            LinkedList expected = new LinkedList(new int[] { 1, 2, 3, 4, 5, 0 });

            yield return new object[] { value, list, expected };


            value = 1;
            list = new LinkedList(new int[] {  });
            expected = new LinkedList(new int[] { 1 });

            yield return new object[] { value, list, expected };


            value = 1;
            list = new LinkedList(new int[] { 2 });
            expected = new LinkedList(new int[] { 2, 1 });

            yield return new object[] { value, list, expected };



            value = -1;
            list = new LinkedList(new int[] { -2, -3, -4 });
            expected = new LinkedList(new int[] { -2, -3, -4, -1 });

            yield return new object[] { value, list, expected };
        }

    }
    
  

}

