using System;
using System.Runtime.InteropServices;

namespace NumberRepresentationConverter
{
    public static class NumberRepresentationConverter
    {
        private const int BITS_IN_BYTE = 8;
        /// <summary>
        /// converter
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string DoubleToBinaryString(this double number)
        {
            DoubleToLongStruct tmp = new DoubleToLongStruct(number);
            long tmp2 = tmp.Long64bits;
            char[] result = new char[64];
            for (int i = 0; i < 64; i++)
            {
                result[i] = (tmp2 & 1) == 0 ? '0' : '1';
                tmp2 >>= 1;
            }
            string results = new string(result);
            results = ReverseString(results);
            return results;
        }
        /// <summary>
        /// string reverse
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        [StructLayout(LayoutKind.Explicit)]
        private struct DoubleToLongStruct
        {
            [FieldOffset(0)]
            private readonly long long64bits;
            [FieldOffset(0)]
            private double double64bits;
            /// <summary>
            /// constructor
            /// </summary>
            /// <param name="number"></param>
            public DoubleToLongStruct(double number) : this()
            {
                double64bits = number;
                long64bits =0;
            }
            /// <summary>
            /// properties 
            /// </summary>
            public long Long64bits
            {
                get
                {
                    return long64bits;
                }
            }
            public double Double64bits
            {
                set
                {
                    double64bits = value;
                }
                get
                {
                    return double64bits;
                }
            }

        }
    }
}
