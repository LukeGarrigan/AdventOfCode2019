using System;
using AdventOfCode2019.Helpers;
using System.Collections.Generic;
namespace AdventOfCode2019.DayFour
{
    public class PasswordFinder
    {

        public int CountCombinations(int start, int end)
        {
            var count = 0;
            for (var i = start; i < end; i++)
            {
                if (IsAscending(i) && HasTwoAdjacent(i))
                {
                    count++;
                }
            }
            return count;
        }

        public bool IsAscending(int i)
        {
            var lastDigit = int.MaxValue;
            while (i != 0)
            {

                if (lastDigit < i % 10)
                {
                    return false;
                }

                lastDigit = i % 10;
                i = (int) Math.Floor(i / 10.0);
            }

            return true;
        }


        public int CountCombinationsPartTwo(int start, int end)
        {
            var count = 0;
            for (var i = start; i < end; i++)
            {
                if (IsAscending(i) && HasOnlyTwoAdjacent(i))
                {
                    count++;
                }
            }
            return count;
        }


        public bool HasTwoAdjacent(int i)
        {
            var lastDigit = int.MaxValue;
            while (i != 0)
            {

                if (lastDigit == i % 10)
                {
                    return true;
                }

                lastDigit = i % 10;
                i = (int)Math.Floor(i / 10.0);
            }

            return false;
        }

        public bool HasOnlyTwoAdjacent(int i)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();

            while (i != 0)
            {
                var lastDigit = i % 10;

                if (counts.ContainsKey(lastDigit))
                {
                    counts[lastDigit] += 1;
                }
                else
                {
                    counts.Add(lastDigit, 1);
                }
                i = (int)Math.Floor(i / 10.0);
            }

            foreach (var x in counts)
            {
                if (x.Value == 2)
                {
                    return true;
                }
            
            }
            return false;
        }
    }
}
