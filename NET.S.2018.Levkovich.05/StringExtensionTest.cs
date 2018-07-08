using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using static ConvertToDecimal.StringExtension;

namespace ConvertToDecimal.Test
{
    using System.Collections;

    [TestFixture]
    public class StringExtensionTest
    {
        [TestCase("0110111101100001100001010111111", 2, ExpectedResult = 934331071)]
        public long ToDec_FromBin(string number, int notation)
            => ToDec(number, notation);
        [TestCase("01101111011001100001010111111", 2, ExpectedResult = 233620159)]
        public long ToDec_FronBin02(string number, int notation)
        {
            return ToDec(number, notation);
        }
        [TestCase("11101101111011001100001010", 2, ExpectedResult = 62370570)]
        public long ToDec_FromBin03(string number, int notation)
        {
            return ToDec(number, notation);
        }
        [TestCase("1AeF101", 16, ExpectedResult = 28242177)]
        public long ToDec_FromSixteen(string number, int notation)
        {
            return ToDec(number, notation);
        }
        [TestCase("1ACB67", 16, ExpectedResult = 1756007)]
        public long ToDec_FromSixteen02(string number, int notation)
        {
            return ToDec(number, notation);
        }
        [TestCase("764241", 8, ExpectedResult = 256161)]
        public long ToDec_fromEight(string number, int notation)
        {
            return ToDec(number, notation);
        }
        [TestCase("10", 5, ExpectedResult = 5)]
        public long ToDec_FromFifth(string number, int notation)
        {
            return ToDec(number, notation);
        }
        [TestCase("1AeF101", 2)]
        public void ToDec_SmalBase(string number, int notation) 
            => Assert.Throws<ArgumentException>(() => ToDec(number, notation));

        [TestCase("1AeF101", 2)]
        public void ToDec_SmalBase02(string number, int notation)
            => Assert.Throws<ArgumentException>(() => ToDec(number, notation));

        [TestCase("11111111111111111111111111111111", 2)]
        public void ToDec_ToBigNumber(string number, int notation)
           => Assert.Throws<OverflowException>(() => ToDec(number, notation));

        [TestCase("764241", 20)]
        public void ToDec_BigBase(string number, int notation)
     => Assert.Throws<ArgumentException>(() => ToDec(number, notation));

    }
}

