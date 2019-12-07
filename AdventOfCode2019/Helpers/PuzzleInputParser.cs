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

        public static List<int> CSVNumbersToList(string filePath)
        {
            var numbersCsv = System.IO.File.ReadAllText(filePath);

            var numbersAsString = numbersCsv.Split(",");
            var numbers = new List<int>();

            for (var i = 0; i < numbersAsString.Length; i++)
            {
                numbers.Add(int.Parse(numbersAsString[i]));
            }

            return numbers;
        }

        public static string GetString(string filePath)
        {
            var myString = System.IO.File.ReadAllText(filePath);
            return myString;
        }
    }
}
