using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace aoc_2022
{
    public class Day2
    {
        //STAR ONE
        public void CountScore(IEnumerable<string> data)
        {
            var totalScore = 0;
            foreach (var game in data)
            {
                if (Regex.Replace(game, @"\s+", "") == "AY") { totalScore += 8; }
                if (Regex.Replace(game, @"\s+", "") == "AX") { totalScore += 4; }
                if (Regex.Replace(game, @"\s+", "") == "AZ") { totalScore += 3; }
                if (Regex.Replace(game, @"\s+", "") == "BY") { totalScore += 5; }
                if (Regex.Replace(game, @"\s+", "") == "BX") { totalScore += 1; }
                if (Regex.Replace(game, @"\s+", "") == "BZ") { totalScore += 9; }
                if (Regex.Replace(game, @"\s+", "") == "CY") { totalScore += 2; }
                if (Regex.Replace(game, @"\s+", "") == "CX") { totalScore += 7; }
                if (Regex.Replace(game, @"\s+", "") == "CZ") { totalScore += 6; }
            }
            Console.WriteLine(totalScore);
        }

        //STAR TWO
        public void CountScore2(IEnumerable<string> data)
        {
            var totalScore = 0;
            var x = 0;
            var y = 3;
            var z = 6;
            foreach (var game in data)
            {
                //LOSE
                if (game.EndsWith("X"))
                {
                    totalScore += x;
                    switch(game.Substring(0, 1)) 
                    {
                        //ROCK
                        case "A":
                            totalScore += 3;
                            break;
                        //PAPER
                        case "B":
                            totalScore += 1;
                            break;
                        //SCISSORS
                        case "C":
                            totalScore += 2;
                            break;
                    }
                }

                //DRAW
                if (game.EndsWith("Y"))
                {
                    totalScore += y;
                    switch(game.Substring(0, 1)) 
                    {
                        //ROCK
                        case "A":
                            totalScore += 1;
                            break;
                        //PAPER
                        case "B":
                            totalScore += 2;
                            break;
                        //SCISSORS
                        case "C":
                            totalScore += 3;
                            break;
                    }
                }

                //WIN
                if (game.EndsWith("Z"))
                {
                    totalScore += z;
                    switch(game.Substring(0, 1)) 
                    {
                        //ROCK
                        case "A":
                            totalScore += 2;
                            break;
                        //PAPER
                        case "B":
                            totalScore += 3;
                            break;
                        //SCISSORS
                        case "C":
                            totalScore += 1;
                            break;
                    }
                }
            }
            Console.WriteLine(totalScore);
        }
    }
}