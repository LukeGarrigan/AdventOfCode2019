using System;
using System.Collections.Generic;
using AdventOfCode2019.Helpers;
namespace AdventOfCode2019.DayTwo
{
    public class IntCode
    {

        public List<int> Codes { get; set; }

        public IntCode(string fileLocation)
        {
            Codes = PuzzleInputParser.CSVNumbersToList(fileLocation);
        }

        public List<int> DoPartOne()
        {
            RestoreGravity();
            return StartComputer();
        }

        private void RestoreGravity()
        {
            // replace position 1 with the value 12 and replace position 2 with the value 2.
            Codes[1] = 12;
            Codes[2] = 2;
        }

        public List<int> StartComputer()
        {
            var index = 0;
            while (index < Codes.Count) {
                var currentOpCode = OpcodeFinder.GetOpcode(Codes[index]);
                if (currentOpCode == CurrentOpCode.HALT)
                {
                    break;
                }
                else if (currentOpCode == CurrentOpCode.SUM)
                {
                    PerformSum(index);
                }
                else if (currentOpCode == CurrentOpCode.MULTIPLY)
                {
                    PerformMultiply(index);
                }
                index += 4;
            }
            return Codes;
            
        }

        private void PerformSum(int index)
        {
            var firstPositionToSum = Codes[index + 1];
            var secondPositionToSum = Codes[index + 2];
            var outputPosition = Codes[index + 3];

            var outputNumber = Codes[firstPositionToSum] + Codes[secondPositionToSum];

            Codes[outputPosition] = outputNumber;
        }


        private void PerformMultiply(int index)
        {
            var firstPositionToMultiply = Codes[index + 1];
            var secondPositionToMultiply = Codes[index + 2];
            var outputPosition = Codes[index + 3];

            var outputNumber = Codes[firstPositionToMultiply] * Codes[secondPositionToMultiply];

            Codes[outputPosition] = outputNumber;
        }


 
    }
}
