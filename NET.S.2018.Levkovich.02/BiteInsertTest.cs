using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static _1.BiteInsert;

namespace _1.Test
{
    [TestClass]
    public class BiteInsertTest
    {
       
        [TestMethod]
        public void InsertWithShift()
        {
            // Arrange
            int expected = InsertNumber(8, 15, 3, 8);

            // Act
            int actual = 120;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InsertWithoutShift()
        {
            // Arrange
            int expected = InsertNumber(15, 15, 0, 0);

            // Act
            int actual = 15;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InsertWithoutShiftAndWithDiffNumber()
        {
            // Arrange
            int expected = InsertNumber(8, 15, 0, 0);

            // Act
            int actual = 9;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void InsertWithNegativeNumber()
        {
            // Arrange
            int expected = InsertNumber(-16, 19, 2, 6);

            // Act
            int actual = -4;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InsertNumber_IndexMoreMaxLength_Exception()
                => InsertNumber(15, 15, 0, 80);

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InsertNumber_NegativeIndex_Exception()
                => InsertNumber(15, 15, -7, 33);

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InsertNumber_jLessThani_Exception()
                => InsertNumber(1, 1, 5, 0);
    }
}
