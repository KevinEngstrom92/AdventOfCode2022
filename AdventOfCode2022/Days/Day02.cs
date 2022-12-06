using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Days
{
    internal class Day02
    {
        string[] rounds;
        const string rock = "X"; //1 pts / lose
        const string paper = "Y"; //2 pts / draw
        const string siccors = "Z"; //3 pts / win

        const string enemyRock = "A";
        const string enemyPaper = "B";
        const string enemySiccors = "C";

        public Day02(string input)
        {
            rounds = input.Split("\r\n");
        }

        public int SolveSilver()
        {
            int score = 0;
            foreach (var round in rounds)
            {
                var innerRound = round.Split(" ");

                if (innerRound[0] == enemyRock && innerRound[1] == paper)
                    score += 8;
                else if (innerRound[0] == enemyPaper && innerRound[1] == paper)
                    score += 5;
                else if (innerRound[0] == enemySiccors && innerRound[1] == paper)
                    score += 2;
                else if (innerRound[0] == enemyPaper && innerRound[1] == siccors)
                    score += 9;
                else if (innerRound[0] == enemySiccors && innerRound[1] == siccors)
                    score += 6;
                else if (innerRound[0] == enemyRock && innerRound[1] == siccors)
                    score += 3;
                else if (innerRound[0] == enemySiccors && innerRound[1] == rock)
                    score += 7;
                else if (innerRound[0] == enemyRock && innerRound[1] == rock)
                    score += 4;
                else if (innerRound[0] == enemyPaper && innerRound[1] == rock)
                    score += 1;
                else
                {
                    //Should never reach this part.
                    // Catch errors in the logic.
                }

            }

            return score;
        }

        public int SolveGold()
        {

            //const string rock = "X"; //1 pts / lose
            //const string paper = "Y"; //2 pts / draw
            //const string siccors = "Z"; //3 pts / win
            int score = 0;
            foreach (var round in rounds)
            {
                var innerRound = round.Split(" ");

                if (innerRound[0] == enemyRock && innerRound[1] == paper)
                    score += 4;
                else if (innerRound[0] == enemyPaper && innerRound[1] == paper)
                    score += 5;
                else if (innerRound[0] == enemySiccors && innerRound[1] == paper)
                    score += 6;
                else if (innerRound[0] == enemyPaper && innerRound[1] == siccors)
                    score += 9;
                else if (innerRound[0] == enemySiccors && innerRound[1] == siccors)
                    score += 7;
                else if (innerRound[0] == enemyRock && innerRound[1] == siccors)
                    score += 8;
                else if (innerRound[0] == enemySiccors && innerRound[1] == rock)
                    score += 2;
                else if (innerRound[0] == enemyRock && innerRound[1] == rock)
                    score += 3;
                else if (innerRound[0] == enemyPaper && innerRound[1] == rock)
                    score += 1;
                else
                {
                    //Should never reach this part.
                    // Catch errors in the logic.
                }

            }

            return score;
        }
    }
}
