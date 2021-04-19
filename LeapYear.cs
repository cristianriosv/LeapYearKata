using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYearKata
{
    class LeapYear
    {
        static public bool IsDivisibleBy400(int year)
        {
            return year % 400 == 0;
        }

        internal static bool IsDivisibleBy100(int year)
        {
            return year % 100 == 0;
        }

        internal static bool IsDivisibleBy4(int year)
        {
            return year % 4 == 0;
        }

        internal static bool IsLeapYear(int year)
        {
            if (IsDivisibleBy400(year)) return true;
            if (!IsDivisibleBy400(year) && IsDivisibleBy100(year)) return false;
            if (IsDivisibleBy4(year) && !IsDivisibleBy100(year)) return true;
            if (!IsDivisibleBy4(year)) return false;
            return false;
        }

        internal static int[] GetAllLeapYearsBetween(int yearIni, int yearEnd)
        {
            List<int> leapYears = new List<int> { };
            for (int year = yearIni + 1; year < yearEnd; year++)
            {
                if (IsLeapYear(year)) leapYears.Add(year);
            }
            return leapYears.ToArray();
        }
    }
}
