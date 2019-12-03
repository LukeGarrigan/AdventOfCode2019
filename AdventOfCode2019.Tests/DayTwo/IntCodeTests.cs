using Microsoft.VisualStudio.TestTools.UnitTesting;

using AdventOfCode2019.DayTwo;
using AdventOfCode2019.Helpers;
using System.Collections.Generic;

namespace AdventOfCode2019.Tests
{
    [TestClass]
    public class IntCodeTest
    {

        private IntCode intcode = new IntCode("DayTwo/Data.txt");


        [TestMethod]
        public void TestCalculateFuelRequiredForPartTwo()
        {
            Assert.AreEqual(165, PuzzleInputParser.CSVNumbersToList("DayTwo/Data.txt").Count);
        }

        [TestMethod]
        public void TestGetOpCode()
        {
            Assert.AreEqual(CurrentOpCode.SUM, OpcodeFinder.GetOpcode(1));
        }

        [TestMethod]
        public void TestSimpleExample()
        {
            intcode.Codes = new List<int>() { 1, 0, 0, 0, 99 };
            Assert.AreEqual(2, intcode.StartComputer());
        }

        [TestMethod]
        public void TestSimpleExample2()
        {
            intcode.Codes = new List<int>() { 1, 1, 1, 4, 99, 5, 6, 0, 99 };
            var expectedOutput = new List<int> { 30, 1, 1, 4, 2, 5, 6, 0, 99 };
            Assert.AreEqual(30, intcode.StartComputer());
        }
        
        [TestMethod]
        public void TestDoPartOne()
        {
            Assert.AreEqual(3101878, intcode.DoPartOne());
        }


        [TestMethod]
        public void TestPartTwo()
        {
            var output = intcode.DoPartTwo();

            Assert.AreEqual(10, output);
        }


    }
}
