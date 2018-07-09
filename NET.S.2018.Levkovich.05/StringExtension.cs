using System;

namespace ConvertToDecimal
{
    /// <summary>
    /// Class convert number to decimal for the base.
    /// </summary>
    public static class StringExtension
    {
        #region Public 

        /// <summary>
        ///  Convert given string number to desimal for the base.
        /// </summary>
        /// <param name="number"> String represenation of numer to convert. </param>
        /// <param name="notation"> Base con converting. </param>
        /// <returns> Decimal number </returns>
        public static long ToDec(string number, int notation)
        {

            if (notation < 2 || notation > 16)
            {
                throw new ArgumentException();
            }

            long result = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int tmp;
                if (StringElement(number, i) < '0' || StringElement(number, i) > '9')
                {
                    tmp = char.ToUpper(StringElement(number, i)) - 'A' + 10;
                    if (tmp >= notation)
                    {
                        throw new ArgumentException();
                    }
                }
                else
                {
                    tmp = StringElement(number, i) - '0';
                    if (tmp >= notation)
                    {
                        throw new ArgumentException();
                    }
                }
                result = (long)Math.Pow(notation, number.Length - i - 1) * tmp + result;

            }

            if (result > int.MaxValue)
            {
                throw new OverflowException();
            }

            return result;
        }

        #endregion

        #region Private

         private static char StringElement(string number, int index)
        {
            char ch = number[index];
            return ch;
        }

        #endregion
       
    }
}