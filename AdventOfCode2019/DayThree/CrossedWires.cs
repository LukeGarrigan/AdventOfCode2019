using System;
using System.Collections.Generic;
using System.Text;

namespace AdventOfCode2019.DayThree
{
    public class CrossedWires
    {

        public int[,] board = new int[1000, 1000];

        public int GenerateWires(string[]first, string[] second)
        {
            GenerateWire(first);
            GenerateWire(second);

            return ManOfClosestPoint();
        }

        private int ManOfClosestPoint()
        {
            var closest = int.MaxValue;
            for (var i = 0; i < board.Length; i++)
            { 
                for (var j = 0; j < board.Length; j++)
                {


                    var distance = i + j;
                    if (board[i, j] == 2 && distance < closest)
                    {
                        closest = distance;
                    }
                }
            
            }
            return closest;
        }

        public void GenerateWire(string[] first)
        {
            var x = 0;
            var y = 0;
            foreach (var command in first)
            {
                var direction = command[0];
                var amount = int.Parse(command.Substring(1, command.Length -1));

                for (var i = 0; i < amount; i++)
                {
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
                    board[x, y] = board[x, y] + 1;
                }



            }
        }
    }
}
