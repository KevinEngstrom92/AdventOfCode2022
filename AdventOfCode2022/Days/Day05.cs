using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AdventOfCode2022.Days
{
    internal class Day05
    {
        List<string> _puzzleList;
        List<Stack<char>> listOfBoxes = new List<Stack<char>>();
        string result = "";

        public Day05(string input)
        {
            _puzzleList = input.Split("\r\n").ToList();
        }

        public string SolveSilver()
        {
           
            int counter = 0;
            foreach (var line in _puzzleList)
            {
                var regex = new Regex("[0-9]");
                if (regex.IsMatch(line))
                {
                    var holder = line.Split(" ");
                    var stackLength = holder.Where(x => !x.Equals(""));
                    var length = int.Parse(stackLength.Last());
                    
                    for(int i = 0; i < length; i++)
                    {
                        listOfBoxes.Add(new Stack<char>());
                    }

                    break;
                }
                counter++;
            }


            var list = _puzzleList.GetRange(0, counter);
            list.Reverse();
            
            var newList = list.Select(s => s.Replace("    ", " ")).ToList();
            foreach (var line in newList)
            {
                var row = line.Split(" ");
                for(int i = 0; i < row.Length; i++)
                {
                    if (row[i].Count() > 0)
                    {
                        var character = row[i][1];
                        listOfBoxes[i].Push(character);

                    }
                }
            }

            var instructions = _puzzleList.Skip(counter + 2);
            foreach (var instruction in instructions)
            {
                var row = instruction.Split(" ");
                var iterations = int.Parse(row[1]);
                var source = int.Parse(row[3]);
                var destination = int.Parse(row[5]);

                for (int i = 0; i < iterations; i++)
                {
                    var move = listOfBoxes[source - 1].Pop();
                    listOfBoxes[destination - 1].Push(move);
                
                }
            }

            StringBuilder str = new StringBuilder();
            foreach (var item in listOfBoxes)
            {
                str.Append(item.Pop());
            }

            return str.ToString();
        }

        public string SolveGold()
        {

            List<Stack<char>> listOfBoxes = new List<Stack<char>>();

            int counter = 0;
            foreach (var line in _puzzleList)
            {
                var regex = new Regex("[0-9]");
                if (regex.IsMatch(line))
                {
                    var holder = line.Split(" ");
                    var stackLength = holder.Where(x => !x.Equals(""));
                    var length = int.Parse(stackLength.Last());
                    
                    for (int i = 0; i < length; i++)
                    {
                        listOfBoxes.Add(new Stack<char>());
                    }

                    break;
                }
                counter++;
            }

            var list = _puzzleList.GetRange(0, counter);
            list.Reverse();

            var newList = list.Select(s => s.Replace("    ", " ")).ToList();
            foreach (var line in newList)
            {
                var row = line.Split(" ");
                for (int i = 0; i < row.Length; i++)
                {
                    if (row[i].Count() > 0)
                    {
                        var character = row[i][1];
                        listOfBoxes[i].Push(character);

                    }

                }

            }

            var instructions = _puzzleList.Skip(counter + 2);
            foreach (var instruction in instructions)
            {
                var x = instruction.Split(" ");
                var iterations = int.Parse(x[1]);
                var source = int.Parse(x[3]);
                var destination = int.Parse(x[5]);
                Stack<char> holderStack = new Stack<char>();
                
                if(iterations < 2)
                {
                    var move = listOfBoxes[source - 1].Pop();
                    listOfBoxes[destination - 1].Push(move);

                }
                else
                {
                    for(int i = 0; i < iterations; i++)
                    {
                        holderStack.Push(listOfBoxes[source - 1].Pop());
                    }

                    for(int i = 0; i < iterations; i++)
                    {
                        listOfBoxes[destination - 1].Push(holderStack.Pop());
                    }

                }

            }

            StringBuilder str = new StringBuilder();
            foreach (var item in listOfBoxes)
            {
                str.Append(item.Pop());

            }

            return str.ToString();
        }
    }
}
