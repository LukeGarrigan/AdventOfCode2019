using System;
using AdventOfCode2019.Helpers;
using System.Collections.Generic;
namespace AdventOfCode2019.DayOne
{
    public class FuelCalculator
    {

        private List<Double> masses;

        public FuelCalculator(string fileLocation)
        {
            masses = PuzzleInputParser.RowsOfNumbersToList(fileLocation);
        }


        public double CalculateFuelRequiredPartTwo()
        {
            var total = 0.0;
            foreach (var mass in masses) {
                total += CalculateFuelRequiredForFuel(mass);
            }
            return total;
        }

        public double CalculateFuelRequiredForFuel(double mass)
        {
            var total = 0.0;
            while (mass > 0)
            {
                mass = CalculateFuelRequiredForMass(mass);
                if (mass > 0) total += mass;
            }
            return total;
        }

        public double CalculateFuelRequiredPartOne()
        {
            var total = 0.0;
            masses.ForEach(mass => total += CalculateFuelRequiredForMass(mass));
            return total;
        }

        public double CalculateFuelRequiredForMass(double mass)
        {
            return Math.Floor(mass / 3) - 2;
        }



        public static void Main(string[] args)
        {

        }


    }
}
