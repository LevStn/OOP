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



        [TestCaseSource(typeof(AddToBeginTestsSource))]
        public void AddToBegineTests(int value, LinkedList list, LinkedList expected)
        {
            list.AddToBegin(value);

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


            list.DeleteToEnd();

            LinkedList actualList = list;

            Assert.AreEqual(expected, actualList);

        }



        [TestCaseSource(typeof(DeleteToBeginTestsSource))]
        public void DeleteToBegineTests(LinkedList list, LinkedList expected)
        {


            list.DeleteToBegin();

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



        [TestCaseSource(typeof(DeleteToEndNElementsTestsSource))]
        public void DeleteToEndNElementsTests(int number, LinkedList list, LinkedList expected)
        {

            list.DeleteToEndNElements(number);
            LinkedList actualList = list;

            Assert.AreEqual(expected, actualList);

        }

        [TestCaseSource(typeof(NegativeDeleteToEndNElementsTestsSource))]
        public void DeleteToEndNElements_WhenNumberMoreLength_ShouldThrowIndexOutOfRangeException(int number, LinkedList list)
        {

            Assert.Throws<InvalidOperationException>(() => list.DeleteToEndNElements(number));

        }



        [TestCaseSource(typeof(DeleteToBeginNElementsTestsSource))]
        public void DeleteToBeginNElementsTests(int number, LinkedList list, LinkedList expected)
        {

            list.DeleteToBeginNElements(number);
            LinkedList actualList = list;

            Assert.AreEqual(expected, actualList);

        }

        [TestCaseSource(typeof(NegativeDeleteToBeginNElementsTestsSource))]
        public void DeleteToBeginNElements_WhenNumberMoreLength_ShouldThrowInvalidOperationException(int number, LinkedList list)
        {

            Assert.Throws<InvalidOperationException>(() => list.DeleteToBeginNElements(number));

        }



        [TestCaseSource(typeof(DeleteByIndexNElementsTestsSource))]
        public void DeleteByIndexNElementsTests(int number, int index, LinkedList list, LinkedList expected)
        {
            list.DeleteByIndexNElements(number, index);

            LinkedList actualList = list;

            Assert.AreEqual(expected, actualList);

        }

        [TestCaseSource(typeof(NegativeFirstDeleteByIndexNElementsTestsSource))]
        public void DeleteByIndexNElements_WhenNumberMoreLength_ShouldThrowInvalidOperationException(int number, int index, LinkedList list)
        {

            Assert.Throws<InvalidOperationException>(() => list.DeleteByIndexNElements(number, index));

        }

        [TestCaseSource(typeof(NegativeSecondDeleteByIndexNElementsTestsSource))]
        public void DeleteByIndexNElements_WhenIndexLess0OrMoreOrEqualLengthOrDifferenceLengthAndNumberLessIndex_ShouldThrowIndexOutOfRangeException( int number, int index, LinkedList list)
        {

            Assert.Throws<IndexOutOfRangeException>(() => list.DeleteByIndexNElements(number, index));

        }



        [TestCaseSource(typeof(ValueByIndexTestsSource))]
        public void ValueByIndexTests(int index, LinkedList list, int expected)
        {
            int actual = list.ValueByIndex(index);

            Assert.AreEqual(expected, actual);

        }
    }   
}
