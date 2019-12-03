using System;
using System.Collections.Generic;
using AdventOfCode2019.Helpers;
namespace AdventOfCode2019.DayTwo
{
    public class IntCode
    {
        private string fileLocation;

        public List<int> Codes { get; set; }

        public IntCode(string fileLocation)
        {
            this.fileLocation = fileLocation;
            Codes = PuzzleInputParser.CSVNumbersToList(fileLocation);
            
        }

        public int DoPartTwo()
        {
            for (var noun = 0; noun <= 99; noun++)
            {
                for (var verb = 0; verb <= 99; verb++)
                {
                    Codes = PuzzleInputParser.CSVNumbersToList(fileLocation); // brilliantly inefficient
                    RestoreGravity(noun, verb);

                    var number = StartComputer();

                    if (number == 19690720)
                    {
                        return noun * 100 + verb;
                    }

                }
            }
            return 0;
        }

        public int DoPartOne()
        {
            RestoreGravity(12, 2);
            return StartComputer();
        }

        private void RestoreGravity(int noun, int verb)
        {
            Codes[1] = noun;
            Codes[2] = verb;
        }

        public int StartComputer()
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
            return Codes[0];
            
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
