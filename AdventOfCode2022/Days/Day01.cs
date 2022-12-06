using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Days
{
    internal class Day01
    {

        List<string> _calsList;

        public Day01(string input) 
        {
            _calsList = input.Split("\r\n").ToList();
        }

        public int GetHighCalorieElfOneStar()
        {
            int previousLargest = 0;
            int totInGroup = 0;
            
            foreach (var caloric in _calsList)
            {
                if(caloric != "")
                {
                    totInGroup += Int32.Parse(caloric);

                }
                else
                {
                    if(totInGroup > previousLargest)
                    {
                        previousLargest = totInGroup;

                    }
                    
                    totInGroup = 0;
                }
            }

            return previousLargest;
        }

        public int GetHighCalorieElfTwoStar()
        {
            List<int> totals = new List<int>();
            int totInGroup = 0;
            
            foreach (var caloric in _calsList)
            {
                if (caloric != "")
                {
                    totInGroup += Int32.Parse(caloric);

                }
                else
                {
                    totals.Add(totInGroup);
                    totInGroup = 0;

                }
            }
            
            totals.Sort((a, b) => b.CompareTo(a));
            int twoStarAnswer = totals.Take(3).Sum(x=> x);
            
            return twoStarAnswer;
        }
    }
}
