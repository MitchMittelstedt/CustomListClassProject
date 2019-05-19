using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProjectUnitTesting;
using CustomListClassProject;

namespace CustomListClassProjectUnitTesting
{
    [TestClass]
    public class Add
    {
        [TestMethod]
        public void Add_OneInteger_ReturnListWithOneInteger()
        {
            //ARRANGE
            CustomList<int> myList = new CustomList<int>();
            int expected;
            int actual;
            int value0 = 5;
            //ACT
            expected = 5;
            myList.Add(value0);
            actual = myList[0];
            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_PositiveIntegers_ReturnsListWithPositiveIntegers()
        {
            //ARRANGE
            CustomList<int> myList = new CustomList<int>();
            int expected;
            int actual;
            int value0 = 5;
            int value1 = 7;
            //ACT
            expected = 7;
            myList.Add(value0);
            myList.Add(value1);
            actual = myList[1];
            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_NegativeIntegers_ReturnsListWithNegativeIntegers()
        {
            //ARRANGE
            CustomList<int> myList = new CustomList<int>();
            int expected;
            int actual;
            int value0 = -3;
            int value1 = -8;
            //ACT
            expected = -3;
            myList.Add(value0);
            myList.Add(value1);
            actual = myList[0];
            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_FiveItems_ReturnsListWithFiveItems()
        {
            //ARRANGE
            CustomList<int> myList = new CustomList<int>();
            int expected;
            int actual;
            int value0 = 11;
            int value1 = 22;
            int value2 = 33;
            int value3 = 44;
            int value4 = 55;
            //ACT
            expected = 55;
            myList.Add(value0);
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            actual = myList[4];
            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_MoreThanTenItems_ReturnsListWithMoreThanTenItems()
        {
            //ARRANGE
            CustomList<int> myList = new CustomList<int>();
            int expected;
            int actual;
            int value0 = 11;
            int value1 = 22;
            int value2 = 33;
            int value3 = 44;
            int value4 = 55;
            int value5 = 66;
            int value6 = 77;
            int value7 = 88;
            int value8 = 99;
            int value9 = 110;
            int value10 = 121;
            //ACT
            expected = 55;
            myList.Add(value0);
            myList.Add(value1);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            myList.Add(value6);
            myList.Add(value7);
            myList.Add(value8);
            myList.Add(value9);
            myList.Add(value10);
            actual = myList[4];
            //ASSERT
            Assert.AreEqual(expected, actual);
        }

    }

    [TestClass]

    public class Remove
    {
        [TestMethod]
        public void Remove_OneInteger_ReturnListWithOneIntegerRemoved()
        {
            //ARRANGE
            CustomList<int> myList = new CustomList<int>();
            int expected;
            int actual;
            int value0 = 7;
            int value1 = 4;
            int value2 = 2;
            //ACT
            myList.Add(value0);
            myList.Add(value1);
            myList.Add(value2);

            myList.Remove(value1);
            expected = 2;
            actual = myList[1];
            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_IntegerNotThere_ReturnListWithSameThreeInegers()
        {
            //ARRANGE
            CustomList<int> myList = new CustomList<int>();
            int expected;
            int actual;
            int value0 = 7;
            int value1 = 4;
            int value2 = 7;
            //ACT
            myList.Add(value0);
            myList.Add(value1);
            myList.Add(value2);
            myList.Remove(70);
            expected = 7;
            actual = myList[2];
            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_OneInteger_ReturnListWithOneFewerInteger()
        {
            //ARRANGE
            CustomList<int> myList = new CustomList<int>();
            int expected;
            int actual;
            int value0 = 7;
            int value1 = 4;
            int value2 = 2;
            //ACT
            myList.Add(value0);
            myList.Add(value1);
            myList.Add(value2);
            myList.Remove(value1);
            expected = 2;
            actual = myList.Count;
            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_NoInteger_ReturnListWithSameCount()
        {
            //ARRANGE
            CustomList<int> myList = new CustomList<int>();
            int expected;
            int actual;
            int value0 = 7;
            int value1 = 4;
            int value2 = 2;
            //ACT
            myList.Add(value0);
            myList.Add(value1);
            myList.Add(value2);
            myList.Remove(70);
            expected = 3;
            actual = myList.Count;
            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_IntegerFromEmptyList_ReturnListEmpty()
        {
            //ARRANGE
            int expected;
            int actual;
            CustomList<int> myList = new CustomList<int>();
            //ACT
            myList.Remove(70);
            expected = 0;
            actual = myList.Count;
            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void Remove_IntegerFromListWithAtLeastFourIntegers_ReturnListWithIntegerRemoved()
        {
            //ARRANGE
            int expected;
            int actual;
            CustomList<int> myList = new CustomList<int>();
            //ACT
            myList.Add(7);
            myList.Add(5);
            myList.Add(5);
            myList.Add(6);
            myList.Add(3);
            myList.Remove(5);
            myList.Add(7);
            expected = 5;
            actual = myList[1];
            //ASSERT
            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]

    public class ToString
    {
        [TestMethod]
        public void ToString_Integer_ReturnIntegerAsString()
        {
            //ARRANGE
            string expected;
            string actual;
            int value = 27;
            //ACT
            expected = "27";
            actual = value.ToString();
            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_Bool_ReturnBoolAsString()
        {
            //ARRANGE
            string expected;
            string actual;
            bool value = true;
            //ACT
            expected = "True";
            actual = value.ToString();
            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_Decimal_ReturnDecimalAsString()
        {
            //ARRANGE
            string expected;
            string actual;
            decimal value = 4.9992M;
            //ACT
            expected = "4.9992";
            actual = value.ToString();
            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_Float_ReturnFloatAsString()
        {
            //ARRANGE
            string expected;
            string actual;
            float value = 4.5F;
            //ACT
            expected = "4.5";
            actual = value.ToString();
            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_Long_ReturnLongAsString()
        {
            //ARRANGE
            string expected;
            string actual;
            long value = -8223372036854775808;
            //ACT
            expected = "-8223372036854775808";
            actual = value.ToString();
            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void plusOperatorTest1_()
        {
            //ARRANGE
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> listOneAndTwo = new CustomList<int>();
            int expected;
            int actual;

            //ACT
            listOne.Add(0);
            listOne.Add(1);
            listOne.Add(2);
            listTwo.Add(0);
            listTwo.Add(1);
            listTwo.Add(2);
            expected = 6;
            listOneAndTwo = listOne + listTwo;
            actual = listOneAndTwo.Count;

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]

        public void plusOperatorTest2()
        {
            //ARRANGE
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> listOneAndTwo = new CustomList<int>();
            int expected;
            int actual;

            //ACT
            listOne.Add(0);
            listOne.Add(1);
            listOne.Add(2);
            listTwo.Add(0);
            listTwo.Add(1);
            listTwo.Add(2);
            listOneAndTwo = listOne + listTwo;
            expected = 1;
            actual = listOneAndTwo[4];

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        public void minusOperatorTest()
        {
            //ARRANGE
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> reducedListOneAndTwo = new CustomList<int>();
            int expected;
            int actual;

            //ACT
            listOne.Add(0);
            listOne.Add(9);
            listOne.Add(2);
            listTwo.Add(0);
            listTwo.Add(1);
            listTwo.Add(2);
            reducedListOneAndTwo = listOne - listTwo;
            expected = 9;
            actual = reducedListOneAndTwo[0];

            //ASSERT
            Assert.AreEqual(expected, actual);
        }
    }
    






    //[TestClass]

    //public class 

}
