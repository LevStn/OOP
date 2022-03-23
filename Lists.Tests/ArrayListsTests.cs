using NUnit.Framework;
using System.Collections;
using Lists.Tests.ArrayListsTestSources;
using Lists;
namespace Lists.Tests
{
    public class Tests
    {

        [TestCaseSource(typeof(DeleteByValueAllTests))]
        public void DeleteByValueAllTests(int value, ArrayList list, ArrayList expectedList, int expectedNumbers)
        {

            int actualNumber = list.DeleteByValueAll(value);

            ArrayList actualList = list;

            Assert.AreEqual(actualNumber, actualNumber);
            Assert.AreEqual(expectedList, actualList);
        }


        [TestCaseSource(typeof(AddValuesToTheEndTestsSource))]
        public void AddValuesToTheEndTests(int value, ArrayList list, ArrayList expected)
        {

            ArrayList actualList = list;
            list.AddValuesToTheEnd(value);

            Assert.AreEqual(expected, actualList);
        }

        [TestCaseSource(typeof(AddValuesToTheEndTestsSource))]
        public void AddValuesToTheBeginTests(int value, ArrayList list, ArrayList expected)
        {

            ArrayList actualList = list;
            list.AddValuesToTheEnd(value);

            Assert.AreEqual(expected, actualList);
        }










    }




    









}


