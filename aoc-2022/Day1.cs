using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Day_1
{
    public class ReturnInput
    {
        static List<Elf> elves = new List<Elf>();
        public static void starOne()
        {
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
            
            var mostCalories = 0;
            var previous = 0;
            //Console.WriteLine("Id {0} Name {1}", listItem.ElfNr, listItem.Calories);
            foreach (var listItem in elves)
            {
                if (listItem.Calories <= previous) continue;
                previous = listItem.Calories;
                mostCalories = listItem.Calories;
            }
            Console.WriteLine("The correct answer is: " + mostCalories);
        }

        public static void starTwo()
        {
            var total = 0;
            elves.Sort(delegate(Elf elf, Elf elf1)
            {
                return elf1.Calories.CompareTo(elf.Calories);
            });

            int i = 0;
            foreach (var elf in elves)
            {
                if (i < 3)
                {
                    total += elf.Calories;
                    i++;
                }
            }
            Console.WriteLine("Top three elves combined: " + total);
        }
    }
}