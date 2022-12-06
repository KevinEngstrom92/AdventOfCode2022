using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Days
{
    internal class Day04
    {
        List<string> _pairList;
        int result = 0;

        public Day04(string input)
        {
            _pairList = input.Split("\r\n").ToList();
        }

        public int SolveSilver()
        {
            foreach (var pair in _pairList)
            {
                var onePair = pair.Split(",");
                var firstRow = onePair[0].Split("-");
                var secondRow = onePair[1].Split("-");

                bool first = int.Parse(firstRow[0]) >= int.Parse(secondRow[0]) && (int.Parse(firstRow[1]) <= int.Parse(secondRow[1]));
                bool second = int.Parse(secondRow[0]) >= int.Parse(firstRow[0]) && (int.Parse(secondRow[1]) <= int.Parse(firstRow[1]));

                if (first || second)
                    result++;

            }
            
            return result;
        }

        public int SolveGold()
        {
            foreach (var pair in _pairList)
            {
                var onePair = pair.Split(",");
                var firstPair = onePair[0].Split("-");
                var secondPair = onePair[1].Split("-");

                var _tempFirst = Enumerable.Range(int.Parse(firstPair[0]),Math.Abs((int.Parse(firstPair[0]) - int.Parse(firstPair[1])))+1);
                var _tempSecond = Enumerable.Range(int.Parse(secondPair[0]), Math.Abs((int.Parse(secondPair[0]) - int.Parse(secondPair[1])))+1);

                var isIntersect = _tempFirst.Intersect(_tempSecond);
                if (isIntersect.Any())
                    result++;

            }

            return result;
        }

    }
}
