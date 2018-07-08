using System;

namespace ConvertToDecimal
{
    /// <summary>
    /// extention 
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// decimal conversion
        /// </summary>
        /// <param name="number"></param>
        /// <param name="notation"></param>
        /// <returns></returns>
        public static long ToDec(string number, int notation)
        {
            if (number.Length >= 32)
                throw new OverflowException();

            if (notation < 2 || notation > 16)
                throw new ArgumentException();

            long result = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int tmp;
                if (StringElement(number, i) < '0' || StringElement(number, i) > '9')
                {
                    tmp = char.ToUpper(StringElement(number, i)) - 'A' + 10;
                    if (tmp >= notation)
                        throw new ArgumentException();
                }
                else
                {
                    tmp = StringElement(number, i) - '0';
                    if (tmp >= notation)
                        throw new ArgumentException();
                }
                result = (long)Math.Pow(notation, number.Length - i - 1) * tmp + result;
                
            }
            return result;
        }
        
        /// <summary>
        /// getting a string item
        /// </summary>
        /// <param name="number"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        private static char StringElement(string number, int index)
        {
            char ch = number[index];
            return ch;

        }
    }
}