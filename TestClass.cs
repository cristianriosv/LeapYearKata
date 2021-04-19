// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using LeapYearKata;

namespace LeapYearKata
{
    /* User Story:

    As a user, I want to know if a year is a leap year, So that I can plan for an extra day on February 29th during those years.

    Acceptance Criteria:

    All years divisible by 400 ARE leap years (so, for example, 2000 was indeed a leap year),
    All years divisible by 100 but not by 400 are NOT leap years(so, for example, 1700, 1800, and 1900 were NOT leap years, NOR will 2100 be a leap year),
    All years divisible by 4 but not by 100 ARE leap years(e.g., 2008, 2012, 2016),
    All years not divisible by 4 are NOT leap years(e.g. 2017, 2018, 2019). */

    [TestFixture]
    public class TestClass
    {
        [TestCase(400, true)]
        [TestCase(2000, true)]
        [TestCase(1999, false)]
        public void TestDivisbleBy400(int year, bool expected)
        {
            bool result = LeapYear.IsDivisibleBy400(year);
            Assert.That(result, Is.EqualTo(expected), $"Expected is {expected} and the result was {result} with year {year}");
        }

        [TestCase(100, true)]
        [TestCase(2000, true)]
        [TestCase(1700, true)]
        [TestCase(1999, false)]
        public void TestDivisbleBy100(int year, bool expected)
        {
            bool result = LeapYear.IsDivisibleBy100(year);
            Assert.That(result, Is.EqualTo(expected), $"Expected is {expected} and the result was {result} with year {year}");
        }

        [TestCase(4, true)]
        [TestCase(2000, true)]
        [TestCase(4000, true)]
        [TestCase(1721, false)]
        public void TestDivisbleBy4(int year, bool expected)
        {
            bool result = LeapYear.IsDivisibleBy4(year);
            Assert.That(result, Is.EqualTo(expected), $"Expected is {expected} and the result was {result} with year {year}");
        }

        [TestCase(2004, true)]
        [TestCase(2008, true)]
        [TestCase(2012, true)]
        [TestCase(2016, true)]
        [TestCase(2003, false)]
        [TestCase(2007, false)]
        [TestCase(2011, false)]
        [TestCase(2015, false)]
        public void TestLeapYear(int year, bool expected)
        {
            bool result = LeapYear.IsLeapYear(year);
            Assert.That(result, Is.EqualTo(expected), $"Expected is {expected} and the result was {result} with year {year}");
        }

        [TestCase(2000, 2100, new int[] { 2004, 2008, 2012, 2016, 2020, 2024, 2028, 2032, 2036, 2040, 2044, 2048, 2052, 2056, 2060, 2064, 2068, 2072, 2076, 2080, 2084, 2088, 2092, 2096 })]
        public void TestLeapYearsFromTo(int yearIni, int yearEnd, int[] expected)
        {
            int[] result = LeapYear.GetAllLeapYearsBetween(yearIni, yearEnd);
            Assert.AreEqual(result, expected, $"Result was {result}");
        }
    }
}

