using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Test
{
    using NUnit.Framework;

    [TestFixture]
    public class JaggedArrayTest
    {
        [Test]
        public void BubbleToMore_Sum()
        {
            int[][] actual =
                { new int[] { 1, 9, 50, 7, 9 }, new int[] { 112, 22, 77, 55 }, new int[] { 37, 41, 6, 94 } };
            ;

            int[][] expected =
                { new int[] { 1, 9, 50, 7, 9 }, new int[] { 37, 41, 6, 94 }, new int[] { 112, 22, 77, 55 } };

            actual.BubbleToMore("SumToMore");

            CollectionAssert.AreEqual(actual, expected);
        }

        [Test]
        public void BubbleToMore_MaxEl()
        {
            int[][] actual =
                { new int[] { 1, 9, 50, 7, 9 }, new int[] { 112, 22, 77, 55 }, new int[] { 37, 41, 6, 94 } };
            ;

            int[][] expected =
                { new int[] { 1, 9, 50, 7, 9 }, new int[] { 37, 41, 6, 94 }, new int[] { 112, 22, 77, 55 } };

            actual.BubbleToMore("MaxEl");

            CollectionAssert.AreEqual(actual, expected);
        }

        [Test]
        public void BubbleToMore_MinEl()
        {
            int[][] actual =
                { new int[] { 1, 9, 50, 7, 9 }, new int[] { 112, 22, 77, 55 }, new int[] { 37, 41, 6, 94 } };
            ;

            int[][] expected =
                { new int[] { 1, 9, 50, 7, 9 }, new int[] { 37, 41, 6, 94 }, new int[] { 112, 22, 77, 55 } };

            actual.BubbleToMore("MinEl");

            CollectionAssert.AreEqual(actual, expected);
        }

        [Test]
        public void BubbleToLess_Sum()
        {
            int[][] actual =
                { new int[] { 1, 9, 50, 7, 9 }, new int[] { 112, 22, 77, 55 }, new int[] { 37, 41, 6, 94 } };
            ;

            int[][] expected =
                { new int[] { 112, 22, 77, 55 }, new int[] { 37, 41, 6, 94 }, new int[] { 1, 9, 50, 7, 9 } };

            actual.BubbleToLess("SumToMore");

            CollectionAssert.AreEqual(actual, expected);
        }

        [Test]
        public void BubbleToLess_MaxEl()
        {
            int[][] actual =
                { new int[] { 1, 9, 50, 7, 9 }, new int[] { 112, 22, 77, 55 }, new int[] { 37, 41, 6, 94 } };
            ;

            int[][] expected =
                { new int[] { 112, 22, 77, 55 }, new int[] { 37, 41, 6, 94 }, new int[] { 1, 9, 50, 7, 9 } };

            actual.BubbleToLess("MaxEl");

            CollectionAssert.AreEqual(actual, expected);
        }

        [Test]
        public void BubbleToLess_MinEl()
        {
            int[][] actual =
                { new int[] { 1, 9, 50, 7, 9 }, new int[] { 112, 22, 77, 55 }, new int[] { 37, 41, 6, 94 } };
            ;

            int[][] expected =
                { new int[] { 112, 22, 77, 55 }, new int[] { 37, 41, 6, 94 }, new int[] { 1, 9, 50, 7, 9 } };

            actual.BubbleToLess("MinEl");

            CollectionAssert.AreEqual(actual, expected);
        }
    }
}
