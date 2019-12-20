using AdventOfCode2019.DaySix;
using FluentAssertions;
using NUnit.Framework;

namespace AdventOfCode2019.Tests.DaySix
{
    [TestFixture]
    public class OrbitFinderTests
    {
        private OrbitMap orbitMap = new OrbitMap();

        [Test]
        public void TestAddingOrbit()
        {
            var input = "A)BSD";
            orbitMap.AddOrbit(input);
            orbitMap.AllOrbits[0].Name.Should().Be("A");
        }


        [Test]
        public void TestAddingOrbits()
        {
            var input = "A)BSD\nS)Dsa";
            orbitMap.AddOrbits(input);
            orbitMap.AllOrbits[0].Name.Should().Be("A");
            orbitMap.AllOrbits[0].Oribiter.Should().Be("BSD");
            orbitMap.AllOrbits[1].Name.Should().Be("S");
            orbitMap.AllOrbits[1].Oribiter.Should().Be("Dsa");
        }


        [Test]
        public void TestFindingMiddlePlanet()
        {
            var input = "A)BSD\r\nS)Dsa\r\nCOM)s\r\nCOM)p";
            orbitMap.AddOrbits(input);

            orbitMap.FindPlanetsOrbiting("COM").Count.Should().Be(2);

        }

        [Test]
        public void TestFindOrbitCount()
        {
            var input = "COM)B\r\nB)C\r\nC)D\r\nD)E\r\nE)F\r\nB)G\r\nG)H\r\nD)I\r\nE)J\r\nJ)K\r\nK)L";
            orbitMap.AddOrbits(input);
            orbitMap.FindOrbitCount().Should().Be(42);
        }


        [Test]
        public void TestDoPartOne()
        {

            orbitMap.DoPartOne("DaySix/data.txt").Should().Be(621125);
        }


        

    }
}
