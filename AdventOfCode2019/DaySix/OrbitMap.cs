using System.Collections.Generic;
using AdventOfCode2019.Helpers;

namespace AdventOfCode2019.DaySix
{
    public class OrbitMap
    {
        public List<Orbit> AllOrbits { get; set; } = new List<Orbit>();

        public int DoPartOne(string fileLocation)
        {
            var input = PuzzleInputParser.GetString(fileLocation);
            AddOrbits(input);
            return FindOrbitCount();
        }

        public int FindOrbitCount()
        {
            var planetsThatOrbitCenter = FindPlanetsOrbiting("COM");
            var queue = new Queue<Orbit>();

            var count = 0;
            planetsThatOrbitCenter.ForEach(planet =>
            {
                planet.Seen = true;
                queue.Enqueue(planet);
            });

            while (queue.Count > 0)
            {
                var currentOrbit = queue.Dequeue();
                count += currentOrbit.AncestorCount;
                foreach (var orbit in FindPlanetsOrbiting(currentOrbit.Oribiter))
                {
                    if (orbit.Seen) continue;
                    orbit.Seen = true;
                    orbit.AncestorCount = currentOrbit.AncestorCount + 1;
                    orbit.Parent = currentOrbit;
                    queue.Enqueue(orbit);
                }
            }

            return count;
        }

        public List<Orbit> FindPlanetsOrbiting(string name)
        {
            return AllOrbits.FindAll(planet => planet.Name.Equals(name));
        }

        public void AddOrbits(string input)
        {
            var orbitInputs = input.Split("\r\n");

            foreach (var orbitInput in orbitInputs)
            {
                AddOrbit(orbitInput);
            }
        }




        public void AddOrbit(string input)
        {
            var data = input.Split(")");

            var orbit = new Orbit
            {
                Oribiter = data[1],
                Name = data[0]
            };

            AllOrbits.Add(orbit);
        }

    }


    public class Orbit
    {
        public string Name { get; set; }
        public string Oribiter { get; set; }

        public Orbit Parent { get; set; }
        public bool Seen { get; set; }

        public int AncestorCount { get; set; } = 1;
    }
}
