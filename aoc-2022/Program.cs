using System;

namespace aoc_2022
{
    class Program {
    
        public static void Main(String[] args)
        {

            var day2 = new Day2();
            day2.countScore(System.IO.File.ReadAllLines(@"C:\Egna_projekt\Advent-of-code\aoc-2022\input\Day2.txt"));

        }
    }
}

