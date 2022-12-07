using System;
using System.Collections.Generic;

namespace aoc_2022
{
    class Program {
    
        public static void Main(String[] args)
        {

            //Day2
            /*var day2 = new Day2();
            day2.CountScore2(System.IO.File.ReadAllLines(@"C:\Egna_projekt\Advent-of-code\aoc-2022\input\Day2.txt"));*/

            /*Day3
             Find the item type that appears in both compartments of each rucksack.
             What is the sum of the priorities of those item types?
            */
            //var day3 = new Day3(3, GetInput(3));
            //Console.WriteLine(day3._sum);
            
            /*Day4
             
              
            */
            var day4 = new Day4(GetInput(4));

        }

        private static IEnumerable<string> GetInput(int day)
        {
            //Your path to the input folder.
            var path = $@"C:\Egna_projekt\Advent-of-code\aoc-2022\input\Day{day}.txt";

            var data = System.IO.File.ReadAllLines(path);
            return data;
        }
    }
}

