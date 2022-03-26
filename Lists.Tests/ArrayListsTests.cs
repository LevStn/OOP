using NUnit.Framework;
using System.Collections;
using Lists.Tests.ArrayListsTestSources;
using Lists;
using System;

namespace Lists.Tests
{
    public class Tests
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



        [TestCaseSource(typeof(FindeIndexByValueTestsSource))]
        public void FindeIndexByValueTests(int value, ArrayList list, int expected)
        {

            int actual = list.FindeIndexByValue(value);

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



        [TestCaseSource(typeof(FindeMaxElementTestsSource))]
        public void FindeMaxElementTests(ArrayList list, int expected)
        {

            int actual = list.FindeMaxElement();

            Assert.AreEqual(actual, expected);
        }

        [TestCaseSource(typeof(NegativeFindeMaxElementTestsSource))]
        public void FindeMaxElement_WheLengthLess1_ShouldThrowException(ArrayList list)
        {
            Assert.Throws<Exception>(() => list.FindeMaxElement());
        }



        [TestCaseSource(typeof(FindeMinElementTestsSource))]
        public void FindeMinElementTests(ArrayList list, int expected)
        {

            int actual = list.FindeMinElement();

            Assert.AreEqual(actual, expected);
        }

        [TestCaseSource(typeof(NegativeFindeMinElementTestsSource))]
        public void FindeMinElement_WhenLengthLess1_ShouldThrowException(ArrayList list)
        {
            Assert.Throws<Exception>(() => list.FindeMinElement());
        }



        [TestCaseSource(typeof(FindeIndexMaxElementTestsSource))]
        public void FindeIndexMaxElementTest(ArrayList list, int expected)
        {
            int actual = list.FindeIndexMaxElement();

            Assert.AreEqual(actual,expected);
        }

        [TestCaseSource(typeof(NegativeFindeIndexMaxElementTestsSource))]
        public void FindeIndexMaxElement_WhenLengthLess1_ShouldThrowException(ArrayList list)
        {
            Assert.Throws<Exception>(() => list.FindeIndexMaxElement());
        }



        [TestCaseSource(typeof(FindeIndexMinElementTestsSource))]
        public void FindeIndexMinElementTest(ArrayList list, int expected)
        {
            int actual = list.FindeIndexMinElement();

            Assert.AreEqual(actual, expected);
        }

        [TestCaseSource(typeof(NegativeFindeIndexMinElementTestsSource))]
        public void FindeIndexMinElement_WhenLengthLess1_ShouldThrowException(ArrayList list)
        {
            Assert.Throws<Exception>(() => list.FindeIndexMinElement());
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
        public void AddListTests (ArrayList list,ArrayList newList, ArrayList expected)
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



    }














}


