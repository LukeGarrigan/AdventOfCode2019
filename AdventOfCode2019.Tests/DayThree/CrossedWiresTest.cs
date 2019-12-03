using Microsoft.VisualStudio.TestTools.UnitTesting;

using AdventOfCode2019.DayThree;
namespace AdventOfCode2019.Tests
{
    [TestClass]
    public class CrossedWiresTest
    {

        private CrossedWires crossedWires = new CrossedWires();

        [TestMethod]
        public void TestGoingRight()
        {
            string[] commands = { "R5", "R2" };
            crossedWires.GenerateWire(commands);
            Assert.AreEqual(1, crossedWires.board[1, 0]);
        }

        [TestMethod]
        public void TestExampleOne()
        {
            string[] commands = { "R75", "D30", "R83", "U83", "L12", "D49", "R71", "U7", "L72" };
            string[] commands2 = { "U62", "R66", "U55", "R34", "D71", "R55", "D58", "R83" };
            
            Assert.AreEqual(159, crossedWires.GenerateWires(commands, commands2));
        }

    }
}
