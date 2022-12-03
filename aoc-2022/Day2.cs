using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace aoc_2022
{
    public class Day2
    {
        
        public void countScore(IEnumerable<string> data)
        {
            var totalScore = 0;
            var AY = 8;
            var AX = 4;
            var AZ = 3;
            var BY = 5;
            var BX = 1;
            var BZ = 9;
            var CY = 2;
            var CX = 7;
            var CZ = 6;

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
    }
}