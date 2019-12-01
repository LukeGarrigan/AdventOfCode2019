using Microsoft.VisualStudio.TestTools.UnitTesting;

using AdventOfCode2019.DayOne;
using AdventOfCode2019.Helpers;

namespace AdventOfCode2019.Tests
{
    [TestClass]
    public class FuelCalculatorTest
    {

        private FuelCalculator fuelCalculator = new FuelCalculator("DayOne/Data.txt");

        [TestMethod]
        public void TestMassOf12()
        {
           Assert.AreEqual(2, fuelCalculator.CalculateFuelRequiredForMass(12));
        }

        [TestMethod]
        public void TestMassOf14()
        {
            Assert.AreEqual(2, fuelCalculator.CalculateFuelRequiredForMass(12));
        }

        [TestMethod]
        public void TestMassOf1969()
        {
            Assert.AreEqual(654, fuelCalculator.CalculateFuelRequiredForMass(1969));
        }

        [TestMethod]
        public void TestParseListOfNumbers()
        {
            Assert.AreEqual(100, PuzzleInputParser.RowsOfNumbersToList("DayOne/Data.txt").Count);
        }

        [TestMethod]
        public void TestMassOfAllModules()
        {
            Assert.AreEqual(3167282, fuelCalculator.CalculateFuelRequiredPartOne());
        }


        [TestMethod]
        public void TestCalculateFuelRequiredForFuel()
        {
            Assert.AreEqual(966, fuelCalculator.CalculateFuelRequiredForFuel(1969));
        }


        [TestMethod]
        public void TestCalculateFuelRequiredForFuel100756()
        {
            Assert.AreEqual(50346, fuelCalculator.CalculateFuelRequiredForFuel(100756));
        }


        [TestMethod]
        public void TestCalculateFuelRequiredForPartTwo()
        {
            Assert.AreEqual(4748063, fuelCalculator.CalculateFuelRequiredPartTwo());
        }


    }
}
