using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2019.Helpers
{
    public class PuzzleInputParser
    {
        public static List<Double> RowsOfNumbersToList(string filePath)
        {
            var rowsOfNumbers = System.IO.File.ReadAllText(filePath);

            List<Double> numbers = new List<double>();
            var numbersAsStrings = rowsOfNumbers.Split("\r\n");
            foreach (var number in numbersAsStrings)
            {
                numbers.Add(int.Parse(number));
            }
            return numbers;
            
        }

    }
}
