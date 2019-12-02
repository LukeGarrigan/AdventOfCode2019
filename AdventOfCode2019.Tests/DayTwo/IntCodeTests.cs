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
            Assert.AreEqual(CurrentOpCode.SUM, intcode.GetOpCode(1));
        }

        [TestMethod]
        public void TestSimpleExample()
        {
            intcode.Codes = new List<int>();
            intcode.Codes.Add(1);
            intcode.Codes.Add(0);
            intcode.Codes.Add(0);
            intcode.Codes.Add(0);
            intcode.Codes.Add(99);

            Assert.AreEqual(2, intcode.StartComputer()[0]);
        }


        [TestMethod]
        public void TestSimpleExample2()
        {
            intcode.Codes = new List<int>();
            intcode.Codes.Add(1);
            intcode.Codes.Add(1);
            intcode.Codes.Add(1);
            intcode.Codes.Add(4);
            intcode.Codes.Add(99);
            intcode.Codes.Add(5);
            intcode.Codes.Add(6);
            intcode.Codes.Add(0);
            intcode.Codes.Add(99);

            Assert.AreEqual(30, intcode.StartComputer()[0]);
        }

        [TestMethod]
        public void TestDoPartOne()
        {
            Assert.AreEqual(30, intcode.StartComputer()[0]);
        }

    }
}
