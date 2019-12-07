using AdventOfCode2019.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2019.DayThree
{

    public class Point
    {

        public int Steps { get; set; }
        public int Value { get; set; }
        public Point(int value, int steps)
        {
            Value = value;
            Steps = steps;
        }

        public void AddIntersection(int value, int steps)
        {
            Steps += steps;
            Value += value;
        }
    }

    public class CrossedWires
    {

        public Dictionary<Tuple<int, int>, Point> board = new Dictionary<Tuple<int, int>, Point>();

        public string[] First;
        public string[] Second;

        public CrossedWires()
        {

        }

        public CrossedWires(string filePath)
        {
            var data = PuzzleInputParser.GetString(filePath);

            var rows = data.Split("\n");
            var firstRow = rows[0];
            var secondRow = rows[1];

            First = firstRow.Split(",");
            Second = secondRow.Split(",");
        }



        public int GenerateWires(string[] first, string[] second)
        {
            GenerateWire(first, 1);
            GenerateWire(second, 2);

            return ManOfClosestPoint();
        }


        public int GenerateWiresPartTwo(string[] first, string[] second)
        {
            GenerateWire(first, 1);
            GenerateWire(second, 2);

            return GetIntersectionWithLeastSteps();
        }

        public void GenerateWire(string[] first, int value)
        {
            var x = 0;
            var y = 0;
            var stepCount = 0;
            foreach (var command in first)
            {
                var direction = command[0];
                var amount = int.Parse(command.Substring(1, command.Length - 1));
                for (var i = 0; i < amount; i++)
                {
                    stepCount += 1;
                    if (direction.Equals('R'))
                    {
                        x++;
                    }
                    else if (direction.Equals('D'))
                    {
                        y--;
                    }
                    else if (direction.Equals('L'))
                    {
                        x--;
                    }
                    else if (direction.Equals('U'))
                    {
                        y++;
                    }

                    var coord = new Tuple<int, int>(x, y);

                    if (board.ContainsKey(coord))
                    {
                        if (board[coord].Value != value)
                        { 
                            board[coord].AddIntersection(value, stepCount);
                        }

                    }
                    else
                    {
                        board.Add(coord, new Point(value, stepCount));
                    }
                }
            }
        }


        private int ManOfClosestPoint()
        {
            var closest = int.MaxValue;

            foreach (KeyValuePair<Tuple<int, int>, Point> entry in board)
            {
                if (entry.Value.Value == 3)
                {
                    var x = entry.Key.Item1;
                    var y = entry.Key.Item2;

                    var man = Math.Abs(x - 0) + Math.Abs(y - 0);
                    if (man < closest)
                    {
                        closest = man;
                    }
                }
            }
            return closest;
        }

        private int GetIntersectionWithLeastSteps()
        {
            var closest = int.MaxValue;
            foreach (KeyValuePair<Tuple<int, int>, Point> entry in board)
            {
                if (entry.Value.Value == 3)
                {
                    var x = entry.Key.Item1;
                    var y = entry.Key.Item2;

                    if (entry.Value.Steps < closest)
                    {
                        closest = entry.Value.Steps;
                    }
                }
            }
            return closest;
        }

    }
}
