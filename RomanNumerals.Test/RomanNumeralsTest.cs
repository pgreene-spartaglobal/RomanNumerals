using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RomanNumerals.Test
{
    [TestFixture]
    class RomanNumeralsTest
    {
        RomanNumeralConverter rnc = new RomanNumeralConverter();
        [Test]
        public void TestIntToRomanNumeral()
        {
            Assert.AreEqual("IV", rnc.IntToRomanNumeral(4));
        }

        [Test]
        public void TestRomanNumeralToInt()
        {
            Assert.AreEqual(2019, rnc.RomanNumeralToInt("MMXIX"));
        }
    }
}
