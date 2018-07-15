using System;

namespace Logic
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// Class with sorting methods
    /// </summary>
    public static class JaggedArray
    {
        /// <summary>
        /// The bubble sort to less.
        /// </summary>
        /// <param name="jaggedArray">
        /// The jagged array.
        /// </param>
        /// <param name="howSort">
        /// The how sort.
        /// </param>
        /// <returns>
        /// The <see cref="int[][]"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// </exception>
        /// <exception cref="ArgumentException">
        /// </exception>
        public static int[][] BubbleToLess(this int[][] jaggedArray, string howSort)
        {
            if (jaggedArray == null)
                throw new ArgumentNullException();
            for (int i = 0; i < jaggedArray.GetLength(0) - 1; i++)
            {
                for (int j = 1; j <= jaggedArray.GetLength(0) - 1; j++)
                {
                    switch (howSort)
                    {
                        case "SumToMore":
                            {
                                if (SumToMore(jaggedArray[i]) < SumToMore(jaggedArray[j]))
                                    Swap(ref jaggedArray[i], ref jaggedArray[j]);
                                break;
                            }
                        case "MaxEl":
                            {
                                if (MaxEl(jaggedArray[i]) < MaxEl(jaggedArray[j]))
                                    Swap(ref jaggedArray[i], ref jaggedArray[j]);
                                break;
                            }
                        case "MinEl":
                            {
                                if (MinEl(jaggedArray[i]) < MinEl(jaggedArray[j]))
                                    Swap(ref jaggedArray[i], ref jaggedArray[j]);
                                break;
                            }
                        default:
                            throw new ArgumentException();
                    }
                }
            }
            return jaggedArray;
        }

        /// <summary>
        /// The bubble sort to more.
        /// </summary>
        /// <param name="jaggedArray">
        /// The jagged array.
        /// </param>
        /// <param name="howSort">
        /// The how sort.
        /// </param>
        /// <returns>
        /// The <see cref="int[][]"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// </exception>
        /// <exception cref="ArgumentException">
        /// </exception>
        public static int[][] BubbleToMore(this int[][] jaggedArray, string howSort)
        {
            if (jaggedArray == null)
                throw new ArgumentNullException();
            for (int i = 0; i < jaggedArray.GetLength(0) - 1; i++)
            {
                for (int j = 1; j <= jaggedArray.GetLength(0) - 1; j++)
                {
                    switch (howSort)
                    {
                        case "SumToMore":
                            {
                                if (SumToMore(jaggedArray[i]) > SumToMore(jaggedArray[j]))
                                    Swap(ref jaggedArray[i], ref jaggedArray[j]);
                                break;
                            }
                        case "MaxEl":
                            {
                                if (MaxEl(jaggedArray[i]) > MaxEl(jaggedArray[j]))
                                    Swap(ref jaggedArray[i], ref jaggedArray[j]);
                                break;
                            }
                        case "MinEl":
                            {
                                if (MinEl(jaggedArray[i]) > MinEl(jaggedArray[j]))
                                    Swap(ref jaggedArray[i], ref jaggedArray[j]);
                                break;
                            }
                        default:
                            throw new ArgumentException();
                    }
                }
            }
            return jaggedArray;
        }

        private static void Swap(ref int[] left, ref int[] rigth)
        {
            int[] tmp = left;
            left = rigth;
            rigth = tmp;
        }
        private static int SumToMore(int[] item)
        {
            int sum = 0;
            for (int i = 0; i < item.Length; i++)
            { sum += item[i]; }
            return sum;
        }
        private static int MaxEl(int[] item)
        {
            int max = item[0];
            for (int i = 1; i < item.Length; ++i)
            {
                if (item[i] > max)
                    max = item[i];
            }
            return max;
        }
        private static int MinEl(int[] item)
        {
            int min = item[0];
            for (int i = 1; i < item.Length; ++i)
            {
                if (item[i] < min)
                    min = item[i];
            }
            return min;
        }
    }
}
