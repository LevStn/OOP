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



        [TestCaseSource(typeof(GetValueByIndexTestsSource))]
        public void GetValueByIndexTests(int index, LinkedList list, int expected)
        {
            int actual = list.GetValueByIndex(index);

            Assert.AreEqual(expected, actual);

        }




        [TestCaseSource(typeof(FindFirstIndexByValueTestsSource))]
        public void FindFirstIndexByValueTests(int value, LinkedList list, int expected)
        {
            int actual = list.FindFirstIndexByValue(value);

            Assert.AreEqual(expected, actual);

        }



        [TestCaseSource(typeof(ChangeValueByIndexTestsSource))]
        public void ChangeValueByIndexTests(int value, int index, LinkedList list, LinkedList expectedList, int expectedOldNumb )
        {
            LinkedList actualList = list;

            int actualOldNumb = list.ChangeValueByIndex(value, index);

            Assert.AreEqual(expectedList, actualList);

            Assert.AreEqual(expectedOldNumb, actualOldNumb);

        }

        [TestCaseSource(typeof (NegativeChangeValueByIndexTestsSource))]
        public void ChangeValueByIndex_WhenIndexLess0OrMoreOrEqualLength_ShouldThrowIndexOutOfRangeException( int value, int index, LinkedList list)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list.ChangeValueByIndex(value, index));
        }



        [TestCaseSource(typeof(ReverseTestsSource))]
        public void ReverseTests(LinkedList list, LinkedList expected)
        {

            LinkedList actualList = list;

            list.Reverse();

            Assert.AreEqual(expected, actualList);
        }


        [TestCaseSource(typeof(FindValueMaxElementTestsSource))]
        public void FindValueMaxElementTests(LinkedList list, int expected)
        {
            

            int actual = list.FindValueMaxElement();

            Assert.AreEqual(expected, actual);

            

        }

        [TestCaseSource(typeof(NegativeFindValueMaxElementTestsSource))]
        public void FindValueMaxElement_WhenRootEqual0_ShouldThrowNullReferenceException( LinkedList list)
        {
            Assert.Throws<NullReferenceException>(() => list.FindValueMaxElement());
        }



        [TestCaseSource(typeof(FindValueMixElementTestsSource))]
        public void FindValueMinElementTests(LinkedList list, int expected)
        {


            int actual = list.FindValueMinElement();

            Assert.AreEqual(expected, actual);



        }

        [TestCaseSource(typeof(NegativeFindValueMaxElementTestsSource))]
        public void FindValueMinElement_WhenRootEqual0_ShouldThrowNullReferenceException(LinkedList list)
        {
            Assert.Throws<NullReferenceException>(() => list.FindValueMaxElement());
        }




        [TestCaseSource(typeof(FindIndexMinElementTestsSource))]
        public void FindIndexMinElementTests(LinkedList list, int expected)
        {

            int actual = list.FindIndexMinElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(NegativeFindIndexMinElementTestsSources))]
        public void FindIndexMinElement_WhenRootEqual0_ShouldThrowNullReferenceException(LinkedList list)
        {
            Assert.Throws<NullReferenceException>(() => list.FindIndexMinElement());
        }



        [TestCaseSource(typeof(FindIndexMaxElementTestsSource))]
        public void FindIndexMaxElementTests(LinkedList list, int expected)
        {

            int actual = list.FindIndexMaxElement();

            Assert.AreEqual(expected, actual);
        }

        [TestCaseSource(typeof(NegativeFindIndexMaxElementTestsSources))]
        public void FindIndexManElement_WhenRootEqual0_ShouldThrowNullReferenceException(LinkedList list)
        {
            Assert.Throws<NullReferenceException>(() => list.FindIndexMaxElement());
        }



        [TestCaseSource(typeof(SortAscendingTestsSource))]
        public void SortAscendingTests(LinkedList list, LinkedList expected)
        {

            LinkedList actualList = list;
            list.SortAscending();

            Assert.AreEqual(expected, actualList);

        }



        [TestCaseSource(typeof(SortDescendingTestsSource))]
        public void SortDescendingTests(LinkedList list, LinkedList expected)
        {

            LinkedList actualList = list;
            list.SortDescending();

            Assert.AreEqual(expected, actualList);

        }



        [TestCaseSource(typeof(DeleteByValueFirstTestsSource))]
        public void DeleteByValueFirstTests(int value, LinkedList list, LinkedList expectedList, int expectedValue)
        {
            int actualValue = list.DeleteByValueFirst(value);
            LinkedList actualList = list;


            Assert.AreEqual(expectedList, actualList);
            Assert.AreEqual(expectedValue, actualValue);

        }



        [TestCaseSource(typeof(DeleteByValueAllTestsSource))]
        public void DeleteByValueAllTests(int value, LinkedList list, LinkedList expectedList, int expectedCount)
        {
            int actualCount = list.DeleteByValueAll(value);
            LinkedList actualList = list;


            Assert.AreEqual(expectedList, actualList);
            Assert.AreEqual(expectedCount, actualCount);

        }


        [TestCaseSource(typeof(AddListToEndTestsSource))]
        public void AddListToEndTests(LinkedList list, LinkedList newList, LinkedList expected)
        {


            LinkedList actualList = list;

            list.AddListToEnd(newList);

            Assert.AreEqual(expected, actualList);


        }
        [TestCaseSource(typeof(NegativeAddListToEndTestsSource))]
        public void AddListToEnd_WhenNewListOrListEqual0_ShouldThrowNullReferenceException(LinkedList list, LinkedList newList)
        {


            Assert.Throws<NullReferenceException>(() => list.AddListToEnd(newList)); ;


        }



        [TestCaseSource(typeof(AddListToBeginTestsSource))]
        public void AddListToBeginTests(LinkedList list, LinkedList newList, LinkedList expected)
        {


            LinkedList actualList = list;

            list.AddListToBegin(newList);

            Assert.AreEqual(expected, actualList);


        }
        [TestCaseSource(typeof(NegativeAddListToBeginTestsSource))]
        public void AddListToBegin_WhenNewListOrListEqual0_ShouldThrowNullReferenceException(LinkedList list, LinkedList newList)
        {

            Assert.Throws<NullReferenceException>(() => list.AddListToBegin(newList)); ;

        }


        [TestCaseSource(typeof(AddListToIndexTestsSource))]
        public void AddListToIndexTests( int index, LinkedList list, LinkedList newList, LinkedList expected)
        {


            LinkedList actualList = list;

            list.AddListToIndex(newList, index);

            Assert.AreEqual(expected, actualList);


        }

        [TestCaseSource(typeof(NegativeFirstAddListToBeginTestsSource))]
        public void AddListToIndex_WhenNewIndexLess0OrMoreLength_ShouldThrowIndexOutOfRangeException(int index, LinkedList list, LinkedList newList)
        {

            Assert.Throws<IndexOutOfRangeException>(() => list.AddListToIndex(newList, index)); ;

        }

        [TestCaseSource(typeof(NegativeSecondAddListToBeginTestsSou))]
        public void AddListToIndex_WhenNewNewListOrListEqualNull_ShouldThrowNullReferenceException(int index, LinkedList list, LinkedList newList)
        {

            Assert.Throws<NullReferenceException>(() => list.AddListToIndex(newList, index)); ;

        }



    }   

}
