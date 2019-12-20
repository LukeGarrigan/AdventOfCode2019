using System;
using System.Collections.Generic;
using AdventOfCode2019.DayThree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2019.Tests.DayThree
{
    [TestClass]
    public class CrossedWiresTest
    {

        private CrossedWires crossedWires = new CrossedWires();

        [TestMethod]
        public void TestCreatingTuples()
        {
            var dictionary = new Dictionary<Tuple<int, int>, int>();
            var tuple = new Tuple<int, int>(1, 2);

            dictionary.Add(tuple, 10);


            var sameTuple = new Tuple<int, int>(1, 2);


            Assert.IsTrue(dictionary.ContainsKey(sameTuple));
        }


        [TestMethod]
        public void TestExampleOne()
        {
            string[] commands = { "R75", "D30", "R83", "U83", "L12", "D49", "R71", "U7", "L72" };
            string[] commands2 = { "U62", "R66", "U55", "R34", "D71", "R55", "D58", "R83" };
            
            Assert.AreEqual(159, crossedWires.GenerateWires(commands, commands2));
        }


        [TestMethod]
        public void TestActualData()
        {
            crossedWires = new CrossedWires("DayThree/data.txt");
            Assert.AreEqual(225, crossedWires.GenerateWires(crossedWires.First, crossedWires.Second));
        }

        [TestMethod]
        public void TestPartTwoExample()
        {
            string[] commands = { "R75", "D30", "R83", "U83", "L12", "D49", "R71", "U7", "L72" };
            string[] commands2 = { "U62", "R66", "U55", "R34", "D71", "R55", "D58", "R83" };

            Assert.AreEqual(610, crossedWires.GenerateWiresPartTwo(commands, commands2));
        }


        [TestMethod]
        public void TestPartTwoExampleTwo()
        {
            string[] commands = { "R98", "U47", "R26", "D63", "R33", "U87", "L62", "D20", "R33", "U53", "R51" };
            string[] commands2 = { "U98", "R91", "D20", "R16", "D67", "R40", "U7", "R15", "U6", "R7" };

            Assert.AreEqual(410, crossedWires.GenerateWiresPartTwo(commands, commands2));
        }


        [TestMethod]
        public void TestPartTwoActualData()
        {
            crossedWires = new CrossedWires("DayThree/data.txt");
            Assert.AreEqual(35194, crossedWires.GenerateWiresPartTwo(crossedWires.First, crossedWires.Second));
        }


    }
}
