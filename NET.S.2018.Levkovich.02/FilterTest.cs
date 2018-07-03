using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static _6.Filter;
    

namespace _6.Test
{
    [TestClass]
    public class FilterTest
    {
        [TestMethod]
        public void FilterGigit_Array_FiltedArray()
        {
            // Arrange
            int[] numeralList = { 7, 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 };
            int number = 7;
            int[] expected = { 7, 7, 70, 17 };

            // Act
            FilterDigit(ref numeralList, number);

            // Assert
            CollectionAssert.AreEqual(expected, numeralList);
        }
        [TestMethod]
        public void FilterDigit_ArrayWithout_EmptyArray()
        {
            int[] numeralList = { 1, 2, 3, 5, 6, 68, 69, 15 };
            int number = 7;
            int[] expected = { };

            FilterDigit(ref numeralList, number);

            CollectionAssert.AreEqual(expected, numeralList);
        }
        //[TestMethod]
        //[ExpectedException(typeof(ArgumentNullException))]
        //public void FilterGigit_InputWithNull_ThrowArgumentNullException()
        //       =>FilterDigit(ref null, 7);
    }
}
