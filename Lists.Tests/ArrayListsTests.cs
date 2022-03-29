using NUnit.Framework;
using System.Collections;
using Lists.Tests.ArrayListsTestSources;
using Lists;
using System;

namespace Lists.Tests
{
    public class ArrayListsTests
    {

        [TestCaseSource(typeof(AddValuesToTheEndTestsSource))]
        public void AddValuesToTheEndTests(int value, ArrayList list, ArrayList expected)
        {

            ArrayList actualList = list;
            list.AddValuesToTheEnd(value);

            Assert.AreEqual(expected, actualList);
        }



        [TestCaseSource(typeof(AddValuesToTheBeginTestsSource))]
        public void AddValuesToTheBeginTests(int value, ArrayList list, ArrayList expected)
        {

            ArrayList actualList = list;
            list.AddValuesToTheBegin(value);

            Assert.AreEqual(expected, actualList);
        }

        

        [TestCaseSource(typeof(AddValuesToIndexTestsSource))]
        public void AddValuesToIndexTests(int value, int index, ArrayList list, ArrayList expected)
        {

            ArrayList actualList = list;
            list.AddValuesToIndex(value, index);

            Assert.AreEqual(expected, actualList);
        }

        [TestCaseSource(typeof(NegativeAddValuesToIndexTestsSource))]
        public void AddValueToIndex_WheIndexLess0orIndexMoreLength_ShouldThrowException(int value,int index, ArrayList list )
        {

            

            Assert.Throws<Exception>(() => list.AddValuesToIndex(value, index));

        }



        [TestCaseSource(typeof(DeleteLastTestsSource))]
        public void DeleteLastTests( ArrayList list, ArrayList expected)
        {

            ArrayList actualList = list;
            list.DeleteLast();

            Assert.AreEqual(expected, actualList);
        }

        [Test]
        public void DeleteLast_WhenListIsEmpty_ShouldThrowException()
        {

            ArrayList list = new ArrayList();
            Assert.Throws<Exception>(() => list.DeleteLast());

        }




        [TestCaseSource(typeof(DeleteBeginTestsSource))]
        public void DeleteBeginTests(ArrayList list, ArrayList expected)
        {

            ArrayList actualList = list;
            list.DeleteBegin();

            Assert.AreEqual(expected, actualList);
        }

        [Test]
        public void DeleteBegin_WhenListIsEmpty_ShouldThrowException()
        {

            ArrayList list = new ArrayList();
            Assert.Throws<Exception>(() => list.DeleteBegin());

        }




        [TestCaseSource(typeof(DeleteByIndexTestsSource))]
        public void DeleteByIndexTests(int index, ArrayList list, ArrayList expectedList, int expectedDeleteNumb)
        {

            int actualDeleteNumb =list.DeleteByIndex(index);

            ArrayList actualList = list;


            Assert.AreEqual(expectedDeleteNumb, actualDeleteNumb);
            Assert.AreEqual(expectedList, actualList);

        }

        [TestCaseSource(typeof(NegativeDeleteByIndexTestsSource))]
        public void DeleteByIndex_WhenIndexEqual0orMoreLength_ShouldThrowException(int index, ArrayList list)
        {

            ArrayList actualList = list;

            Assert.Throws<Exception>(() => list.DeleteByIndex(index));

        }




        [TestCaseSource(typeof(DeleteTHeEndNElementsTestsSource))]
        public void DeleteTHeEndNElementsTests(int number, ArrayList list, ArrayList expected)
        {

            ArrayList actualList = list;
            list.DeleteTHeEndNElements(number);

            Assert.AreEqual(expected, actualList);
        }

        [TestCaseSource(typeof(NegativeDeleteTHeEndNElementsTestsSource))]
        public void DeleteTHeEndNElements_WhenNumberMoreLength_ShouldThrowException(int number, ArrayList list)
        {
            ArrayList actualList = list;

            Assert.Throws<Exception>(() => list.DeleteTHeEndNElements(number));
        }




        [TestCaseSource(typeof(DeleteTHeBegineNElementsTestsSource))]
        public void DeleteTHeBegineNElementsTests(int number, ArrayList list, ArrayList expected)
        {

            ArrayList actualList = list;
            list.DeleteTHeBegineNElements(number);

            Assert.AreEqual(expected, actualList);
        }

        [TestCaseSource(typeof(NegativeDeleteTHeBegineNElementsTestsSource))]
        public void DeleteTHeBegineNElements_WhenNumberMoreLength_ShouldThrowException(int number, ArrayList list)
        {
            ArrayList actualList = list;

            Assert.Throws<Exception>(() => list.DeleteTHeBegineNElements(number));
        }




        [TestCaseSource(typeof(DeleteByIndexNElemetsTestsSource))]
        public void DeleteByIndexNElemetsTests(int index, int number, ArrayList list, ArrayList expected)
        {

            ArrayList actualList = list;
            list.DeleteByIndexNElemets(index, number);

            Assert.AreEqual(expected, actualList);
        }

        [TestCaseSource(typeof(NegativeDeleteByIndexNElemetsTestsSource))]
        public void DeleteByIndexNElemets_WhenNumberandIndexLess0OrMoreLength_ShouldThrowException(int index, int number, ArrayList list)
        {
            ArrayList actualList = list;

            Assert.Throws<Exception>(() => list.DeleteByIndexNElemets(index, number));
        }



        [TestCaseSource(typeof(GetValueIndexTestsSource))] 
        public void GetValueIndexTests(int index, ArrayList list, int expected)
        {

           int actual = list.GetValueIndex(index);

            Assert.AreEqual(actual, expected);

        }

        [TestCaseSource(typeof(NegativeGetValueIndexTestsSource))]
        public void GetValueIndex_WhenIndexLess0OrMoreOrEqualLength_ShouldThrowException(int index, ArrayList list)
        {
            

            Assert.Throws<Exception>(() => list.GetValueIndex(index));
        }



        [TestCaseSource(typeof(FindIndexByValueTestsSource))]
        public void FindIndexByValueTests(int value, ArrayList list, int expected)
        {

            int actual = list.FindIndexByValue(value);

            Assert.AreEqual(actual, expected);

        }



        [TestCaseSource(typeof(ChangesByIndexTestsSource))]
        public void ChangesByIndexTests(int index, int value, ArrayList list, ArrayList expectedList, int expectedOldNummb)
        {

            int actual = list.ChangesByIndex(index, value);
            ArrayList actualList = list;

            Assert.AreEqual(actual, expectedOldNummb);
            Assert.AreEqual(actualList, expectedList);


        }

        [TestCaseSource(typeof(NegativeChangesByIndexTestsSource))]
        public void ChangesByIndex_WhenIndexLess0orMoreOrEqualLength_ShouldThrowException(int index, int value, ArrayList list)
        {


            Assert.Throws<Exception>(() => list.ChangesByIndex(index, value));
        }



        [TestCaseSource(typeof(ReverseTestsSource))]
        public void ReverseTests(ArrayList list, ArrayList expected)
        {


            ArrayList actualList = list;
            list.Reverse();

            Assert.AreEqual(actualList, expected);
        }



        [TestCaseSource(typeof(FindMaxElementTestsSource))]
        public void FindeMaxElementTests(ArrayList list, int expected)
        {

            int actual = list.FindMaxElement();

            Assert.AreEqual(actual, expected);
        }

        [TestCaseSource(typeof(NegativeFindeMaxElementTestsSource))]
        public void FindeMaxElement_WheLengthLess1_ShouldThrowException(ArrayList list)
        {
            Assert.Throws<Exception>(() => list.FindMaxElement());
        }



        [TestCaseSource(typeof(FindMinElementTestsSource))]
        public void FindeMinElementTests(ArrayList list, int expected)
        {

            int actual = list.FindMinElement();

            Assert.AreEqual(actual, expected);
        }

        [TestCaseSource(typeof(NegativeFindMinElementTestsSource))]
        public void FindeMinElement_WhenLengthLess1_ShouldThrowException(ArrayList list)
        {
            Assert.Throws<Exception>(() => list.FindMinElement());
        }



        [TestCaseSource(typeof(FindIndexMaxElementTestsSource))]
        public void FindeIndexMaxElementTest(ArrayList list, int expected)
        {
            int actual = list.FindIndexMaxElement();

            Assert.AreEqual(actual,expected);
        }

        [TestCaseSource(typeof(NegativeFindIndexMaxElementTestsSource))]
        public void FindeIndexMaxElement_WhenLengthLess1_ShouldThrowException(ArrayList list)
        {
            Assert.Throws<Exception>(() => list.FindIndexMaxElement());
        }



        [TestCaseSource(typeof(FindIndexMinElementTestsSource))]
        public void FindeIndexMinElementTest(ArrayList list, int expected)
        {
            int actual = list.FindIndexMinElement();

            Assert.AreEqual(actual, expected);
        }

        [TestCaseSource(typeof(NegativeFindIndexMinElementTestsSource))]
        public void FindeIndexMinElement_WhenLengthLess1_ShouldThrowException(ArrayList list)
        {
            Assert.Throws<Exception>(() => list.FindIndexMinElement());
        }



        [TestCaseSource(typeof(GetSortAscendingTestsSource))]
        public void GetSortAscendingTests(ArrayList list, ArrayList expected)
        {

            ArrayList actual = list;
            list.GetSortAscending();

            Assert.AreEqual(actual, expected);
        }



        [TestCaseSource(typeof(GetSortDecendingTestsSource))]
        public void GetSortDecendingTests(ArrayList list, ArrayList expected)
        {

            ArrayList actual = list;
            list.GetSortDecending();

            Assert.AreEqual(actual, expected);
        }



        [TestCaseSource(typeof(DeleteByValueFirstTestsSource))]
        public void DeleteByValueFirstTests(int value, ArrayList list, int expectedIndex, ArrayList expectedList)
        {
            int actualIndex = list.DeleteByValueFirst(value);
            ArrayList actualList = list;

            Assert.AreEqual(actualIndex, expectedIndex);
            Assert.AreEqual(actualList, expectedList);
        }




        [TestCaseSource(typeof(DeleteByValueAllTestsSource))]
        public void DeleteByValueAllTests(int value, ArrayList list, ArrayList expectedList, int expectedNumbers)
        {

            int actualNumber = list.DeleteByValueAll(value);

            ArrayList actualList = list;

            Assert.AreEqual(expectedNumbers, actualNumber);
            Assert.AreEqual(expectedList, actualList);
        }



        [TestCaseSource(typeof(AddListToEndTestsSource))]
        public void AddListToendTests (ArrayList list,ArrayList newList, ArrayList expected)
        {

                
           ArrayList actualList= list;
           list.AddListToEnd(newList);

            Assert.AreEqual(expected, actualList);


        }

        [TestCaseSource(typeof(NegativeAddListToEndTestsSource))]
        public void AddListToEnd_WhenNewListIsEqual0_ShouldThrowNullReferenceException(ArrayList list , ArrayList Newlist)
        {
            Assert.Throws<NullReferenceException>(() => list. AddListToEnd(Newlist));
        }



        [TestCaseSource(typeof(AddListToBeginTestsSource))]
        public void AddListToBeginTests(ArrayList list, ArrayList newList, ArrayList expected)
        {


            ArrayList actualList = list;
            list.AddListToBegin(newList);

            Assert.AreEqual(expected, actualList);


        }

        [TestCaseSource(typeof(NegativeAddListToBeginTestsSource))]
        public void AddListToBegin_WhenNewListIsEqual0_ShouldThrowNullReferenceException(ArrayList list, ArrayList Newlist)
        {
            Assert.Throws<NullReferenceException>(() => list.AddListToEnd(Newlist));
        }



        [TestCaseSource(typeof(AddListToIndexTestsSource))]
        public void AddListToIndexTests(ArrayList list, ArrayList newList, int index, ArrayList expected)
        {


            ArrayList actualList = list;
            list.AddListToIndex(newList, index);

            Assert.AreEqual(expected, actualList);


        }

        [TestCaseSource(typeof(NegativeAddListToIndexTestsSource))]
        public void AddListToIndex_WhenNewListIsEqual0_ShouldThrowNullReferenceException(ArrayList list, ArrayList Newlist, int index)
        {
            Assert.Throws<NullReferenceException>(() => list.AddListToIndex (Newlist, index)); ;
        }

        [TestCaseSource(typeof(Negative2AddListToIndexTestsSource))]
        public void AddListToIndex_WhenIndexMoreLength_ShouldThrowNullIndexOutOfRangeException(ArrayList list, ArrayList Newlist, int index)
        {
            Assert.Throws<IndexOutOfRangeException>(() => list.AddListToIndex(Newlist, index)); ;
        }

    }














}


