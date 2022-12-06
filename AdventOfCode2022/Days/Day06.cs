using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Days
{
    internal class Day06
    {
        List<string> _puzzleList;
        int result;

        public Day06(string input)
        {
            _puzzleList = input.Split("\r\n").ToList();
        }

        public int SolveSilver()
        {
            foreach (var row in _puzzleList)
            {
                for(int i = 0; i < row.Count(); i++)
                {
                    var takenLetters = row.Skip(i).Take(4);
                    if(takenLetters.Count() != takenLetters.Distinct().Count())
                    {
                        continue;
                    }

                    result = i + 4;
                    break;
                }
            }
            return result;
        }

        public int SolveGold()
        {
            foreach (var row in _puzzleList)
            {
                for (int i = 0; i < row.Count(); i++)
                {
                    var takenLetters = row.Skip(i).Take(14);
                    if (takenLetters.Count() != takenLetters.Distinct().Count())
                    {
                        continue;
                    }

                    result = i + 14;
                    break;
                }
            }
            return result;
        }
    }
}
