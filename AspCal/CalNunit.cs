using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspCal
{
    [TestFixture]
    public class CalNunit
    {
        [TestCase]
        public void Test_Add()
        {
            //Arrange
            int expected = 12;
            int val1 = 8;
            int val2 = 4;

            //Act
            int actual = AspcalDll.Calculator.Add(val1, val2);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase]
        public void Test_sub()
        {
            //Arrange
            int expected = 4;
            int val1 = 8;
            int val2 = 4;

            //Act
            int actual = AspcalDll.Calculator.Sub(val1, val2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase]
        public void Test_mul()
        {
            //Arrange
            int expected = 32;
            int val1 = 8;
            int val2 = 4;

            //Act
            int actual = AspcalDll.Calculator.Mul(val1, val2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase]
        public void Test_div()
        {
            //Arrange
            int expected = 2;
            int val1 = 8;
            int val2 = 4;

            //Act
            int actual = AspcalDll.Calculator.Div(val1, val2);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}