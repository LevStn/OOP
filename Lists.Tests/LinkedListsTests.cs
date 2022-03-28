using NUnit.Framework;
using System.Collections;
using Lists;
using System;
using Lists.Tests.LinkedListsTestsSources;

namespace Lists.Tests
{
    public class LinkedListsTests
    {

        [TestCaseSource(typeof(AddToEndTestsSource))]
        public void AddToEndTests(int value, LinkedList list, LinkedList expected)
        {
            list.AddToEnd(value);

            LinkedList actualList = list;

            Assert.AreEqual(expected, actualList);

        }



        [TestCaseSource(typeof(AddToBegineTestsSource))]
        public void AddToBegineTests(int value, LinkedList list, LinkedList expected)
        {
            list.AddToBegine(value);

            LinkedList actualList = list;

            Assert.AreEqual(expected, actualList);

        }



        [TestCaseSource(typeof(AddToIndexTestsSource))]
        public void AddToIndexTests(int value, int index, LinkedList list, LinkedList expected)
        {
            list.AddToIndex(value, index);

            LinkedList actualList = list;

            Assert.AreEqual(expected, actualList);

        }

        [TestCaseSource(typeof(NegativeAddToIndexTestsSource))]
        public void AddToIndex_WhenIndexMoreLengthOrLess0_ShouldThrowIndexOutOfRangeException(int value, int index, LinkedList list)
        {
            
            
            Assert.Throws<IndexOutOfRangeException>(() => list.AddToIndex(value, index));
        }



        [TestCaseSource(typeof(DeleteToEndTestsSource))]
        public void DeleteToEndTests(LinkedList list, LinkedList expected)
        {


            list.DelleteToEnd();

            LinkedList actualList = list;

            Assert.AreEqual(expected, actualList);

        }



        [TestCaseSource(typeof(DeleteToBegineTestsSource))]
        public void DeleteToBegineTests(LinkedList list, LinkedList expected)
        {


            list.DelleteToBegine();

            LinkedList actualList = list;

            Assert.AreEqual(expected, actualList);

        }



        [TestCaseSource(typeof(DeleteByIndexTestsSource))]
        public void DeleteByIndexTests(int index, LinkedList list, LinkedList expected)
        {
            list.DeleteByIndex(index);

            LinkedList actualList = list;

            Assert.AreEqual(expected, actualList);

        }

        [TestCaseSource(typeof(NegativeDeleteByIndexTestsSource))]
        public void DeleteByIndex_WhenIndexMoreLengthOrLess0_ShouldThrowIndexOutOfRangeException(int index, LinkedList list)
        {

            Assert.Throws<IndexOutOfRangeException>(() => list.DeleteByIndex(index));

        }




    }
}
