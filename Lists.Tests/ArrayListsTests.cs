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
        public void DeleteByIndexNElemetsTestsSource_WhenNumberandIndexLess0OrMoreLength_ShouldThrowException(int index, int number, ArrayList list)
        {
            ArrayList actualList = list;

            Assert.Throws<Exception>(() => list.DeleteByIndexNElemets(index, number));
        }


        [TestCaseSource(typeof(GetValueIndexTestsSource))] 
        public void GetValueIndexTests(int index, ArrayList list, int expected)
        {

           int actual= list.GetValueIndex(index);

            Assert.AreEqual(actual, expected);

        }

        [TestCaseSource(typeof(NegativeGetValueIndexTestsSource))]
        public void DeleteByIndexNElemetsTestsSource_WhenIndexLess0OrMoreOrEqualLength_ShouldThrowException(int index, ArrayList list)
        {
            

            Assert.Throws<Exception>(() => list.GetValueIndex(index));
        }










        [TestCaseSource(typeof(DeleteByValueAllTests))]
        public void DeleteByValueAllTests(int value, ArrayList list, ArrayList expectedList, int expectedNumbers)
        {

            int actualNumber = list.DeleteByValueAll(value);

            ArrayList actualList = list;

            Assert.AreEqual(expectedNumbers, actualNumber);
            Assert.AreEqual(expectedList, actualList);
        }

    }




    









}


