using AdventOfCode2019.DayFour;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode2019.Tests.DayFour
{
    [TestClass]
    public class PasswordFinderTests
    {

        private PasswordFinder passwordFinder = new PasswordFinder();

        [TestMethod]
        public void TestAscending1()
        {
            Assert.IsTrue(passwordFinder.IsAscending(12));
            Assert.IsTrue(passwordFinder.IsAscending(1234));
            Assert.IsTrue(passwordFinder.IsAscending(122334499));
        }


        [TestMethod]
        public void TestAscending2()
        {
            Assert.IsFalse(passwordFinder.IsAscending(212));
            Assert.IsFalse(passwordFinder.IsAscending(223450));
            Assert.IsTrue(passwordFinder.IsAscending(111111));
        }


        [TestMethod]
        public void TestHasTwoAdjacent()
        {
            Assert.IsTrue(passwordFinder.HasTwoAdjacent(1122));
            Assert.IsFalse(passwordFinder.HasTwoAdjacent(1234));
        }



        [TestMethod]
        public void TestHasTwoAdjacentCont()
        {
            Assert.IsFalse(passwordFinder.HasTwoAdjacent(123789));
        }

        

        [TestMethod]
        public void TestPartOne()
        {
            Assert.AreEqual(1099, passwordFinder.CountCombinations(245182, 790572)); 
        }


        [TestMethod]
        public void TestHasOnlyTwoAdjacent()
        {
            Assert.IsTrue(passwordFinder.HasOnlyTwoAdjacent(112222)); 
            Assert.IsFalse(passwordFinder.HasOnlyTwoAdjacent(2313333)); 
        }



        [TestMethod]
        public void TestPartTwo()
        {
            Assert.AreEqual(710, passwordFinder.CountCombinationsPartTwo(245182, 790572));
        }

    }
}
