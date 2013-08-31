using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LeapYear
{
    [TestFixture]
    public class LeapYear
    {
        [Test]
        [TestCase(1996)]
        [TestCase(2000)]
        public void Test_Is_Leap_Year(int year)
        {
            Assert.IsTrue(IsLeapYear(year));
        }

        [Test]
        [TestCase(2001)]
        [TestCase(1900)]
        public void Test_Is_Common_Year(int year)
        {
            Assert.IsFalse(IsLeapYear(2001));
        }

        private bool IsLeapYear(int year)
        {
            if (IsATypicalCommonYear(year))
                return false;
            return IsTypicalLeapYear(year);
        }

        private static bool IsTypicalLeapYear(int year)
        {
            return year % 4 == 0;
        }

        private static bool IsATypicalCommonYear(int year)
        {
            return year % 100 == 0 && year % 400 != 0;
        }

    }
}
