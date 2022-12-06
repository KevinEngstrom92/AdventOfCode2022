using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Days
{
    internal class Day03
    {

        List<string> _rusackList;
        List<char> doublePlacedItems = new List<char>();

        public Day03(string input)
        {
            _rusackList = input.Split("\r\n").ToList();
        }

        public int SolveSilver()
        {
            foreach (var compartment in _rusackList)
            {
                var _tempArray = compartment.Substring(0,compartment.Length / 2);
                var _tempArray2 = compartment.Substring(compartment.Length / 2);

                doublePlacedItems.AddRange(_tempArray.Intersect(_tempArray2));
               
            }

            const int ASCIISmall = 96;
            const int ASCIICapital = 64 - 26;
            int sum = 0;

            foreach (var asciichar in doublePlacedItems)
            {
                if (char.IsLower(asciichar))
                    sum += ((int)(asciichar) - ASCIISmall);
                else
                    sum += ((int)(asciichar) - ASCIICapital);

            }

            return sum;
        }

        public int SolveGold()
        {

            for(int i = 0; i < _rusackList.Count; i += 3)
            {
                var _tempArrays = _rusackList.Skip(i).Take(3).ToList();
                var _result = (_tempArrays[0].Intersect(_tempArrays[1])).Intersect(_tempArrays[2]);

                doublePlacedItems.AddRange(_result);
            }

            const int ASCIISmall = 96;
            const int ASCIICapital = 64 - 26;
            int sum = 0;

            foreach (var asciichar in doublePlacedItems)
            {
                if (char.IsLower(asciichar))
                    sum += ((int)(asciichar) - ASCIISmall);
                else
                    sum += ((int)(asciichar) - ASCIICapital);

            }

            return sum;
        }


    }
}
