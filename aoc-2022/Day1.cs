using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Day_1
{
    public class ReturnInput
    {
        public static void dayOne()
        {
            var elves = new List<Elf>();
            var data = System.IO.File.ReadAllLines(@"C:\projects\advent-of-code-2022\aoc-2022\input\Day1.txt");
            var calories = 0;
            var elf = 1;

            foreach (var line in data)
            {
                if (int.TryParse(line, out int output))
                {
                    calories += int.Parse(line);
                }
                else
                {
                    elves.Add(new Elf(elf, calories));
                    elf += 1;
                    calories = 0;
                }
            }
            elves.Add(new Elf(elf, calories));
            
            var c = 0;
            var previous = 0;
            foreach (var listItem in elves)
            {
                //Console.WriteLine("Id {0} Name {1}", listItem.ElfNr, listItem.Calories);
                if (listItem.Calories <= previous) continue;
                previous = listItem.Calories;
                c = listItem.Calories;
            }
            Console.WriteLine("The correct answer is: " + c);
        }
    }
}