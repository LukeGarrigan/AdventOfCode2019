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
                var currentOpCode = GetOpCode(Codes[index]);
                if (currentOpCode == CurrentOpCode.HALT)
                {
                    break;
                }
                else if (currentOpCode == CurrentOpCode.SUM)
                {
                    var firstPositionToSum = Codes[index + 1];
                    var secondPositionToSum = Codes[index + 2];
                    var outputPosition = Codes[index + 3];

                    var outputNumber = Codes[firstPositionToSum] + Codes[secondPositionToSum];

                    Codes[outputPosition] = outputNumber;
                }
                else if (currentOpCode == CurrentOpCode.MULTIPLY)
                {
                    var firstPositionToMultiply = Codes[index + 1];
                    var secondPositionToMultiply = Codes[index + 2];
                    var outputPosition = Codes[index + 3];

                    var outputNumber = Codes[firstPositionToMultiply] * Codes[secondPositionToMultiply];

                    Codes[outputPosition] = outputNumber;
                }
                index += 4;
            }
            return Codes;
            
        }


        public CurrentOpCode GetOpCode(int number)
        {
            if (number == 1)
            {
                return CurrentOpCode.SUM;
            }
            else if (number == 2)
            {
                return CurrentOpCode.MULTIPLY;
            }
            else if (number == 99)
            {
                return CurrentOpCode.HALT;
            }
            else
            {
                return CurrentOpCode.NONE;
            }

        }
    }
}
