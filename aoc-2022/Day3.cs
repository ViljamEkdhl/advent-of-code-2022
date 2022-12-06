using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace aoc_2022
{
    public class Day3
    {
        private readonly int _groupSize;
        private readonly IEnumerable<string> _data;
        public int _sum;
        public Day3(int groupSize, IEnumerable<string> data)
        {
            this._groupSize = groupSize;
            this._data = data;
            CalculateSum();
        }
        
        private void CalculateSum()
        {
            var groupsOfElfs = new List<string>();
            foreach (var backpack in _data)
            {
                if (_groupSize == 1)
                {
                    _sum += SplitCompartments(backpack);
                }
                else
                {   
                    groupsOfElfs.Add(backpack);
                    if (groupsOfElfs.Count == 3)
                    {
                        _sum += FindGroups(groupsOfElfs);
                        groupsOfElfs.Clear();
                    }
                    
                }
            }
        }

        private int SplitCompartments(string backpack)
        {
            var length = backpack.Length;;
            var firstCompartment = backpack.Substring(0, length / 2);
            var secondCompartment = backpack.Substring((length / 2), length / 2);
            var firstList = firstCompartment.ToList();

            foreach (var character in firstList)
            {
                if (secondCompartment.Contains(character))
                { 
                    return SuperAwesomePointThingie(character);
                }
            }

            return 0;
        }

        private static int FindGroups(List<string> groupOfElves)
        {

            foreach (var elf in groupOfElves)
            {
                var firstList = elf.ToList();
                foreach (var character in firstList)
                {
                    if (groupOfElves[1].Contains(character) && groupOfElves[2].Contains(character))
                    {
                        return SuperAwesomePointThingie(character);
                    }
                }
            }
            return 0;
        }

        private static int SuperAwesomePointThingie(char character)
        {
                    if (character.ToString() == "a") { return 1; }
                    if (character.ToString() == "b") { return 2; }
                    if (character.ToString() == "c") { return 3; }
                    if (character.ToString() == "d") { return 4; }
                    if (character.ToString() == "e") { return 5; }
                    if (character.ToString() == "f") { return 6; }
                    if (character.ToString() == "g") { return 7; }
                    if (character.ToString() == "h") { return 8; }
                    if (character.ToString() == "i") { return 9; }
                    if (character.ToString() == "j") { return 10; }
                    if (character.ToString() == "k") { return 11; }
                    if (character.ToString() == "l") { return 12; }
                    if (character.ToString() == "m") { return 13; }
                    if (character.ToString() == "n") { return 14; }
                    if (character.ToString() == "o") { return 15; }
                    if (character.ToString() == "p") { return 16; }
                    if (character.ToString() == "q") { return 17; }
                    if (character.ToString() == "r") { return 18; }
                    if (character.ToString() == "s") { return 19; }
                    if (character.ToString() == "t") { return 20; }
                    if (character.ToString() == "u") { return 21; }
                    if (character.ToString() == "v") { return 22; }
                    if (character.ToString() == "w") { return 23; }
                    if (character.ToString() == "x") { return 24; }
                    if (character.ToString() == "y") { return 25; }
                    if (character.ToString() == "z") { return 26; }
                    if (character.ToString() == "A") { return 27; }
                    if (character.ToString() == "B") { return 28; }
                    if (character.ToString() == "C") { return 29; }
                    if (character.ToString() == "D") { return 30; }
                    if (character.ToString() == "E") { return 31; }
                    if (character.ToString() == "F") { return 32; }
                    if (character.ToString() == "G") { return 33; }
                    if (character.ToString() == "H") { return 34; }
                    if (character.ToString() == "I") { return 35; }
                    if (character.ToString() == "J") { return 36; }
                    if (character.ToString() == "K") { return 37; }
                    if (character.ToString() == "L") { return 38; }
                    if (character.ToString() == "M") { return 39; }
                    if (character.ToString() == "N") { return 40; }
                    if (character.ToString() == "O") { return 41; }
                    if (character.ToString() == "P") { return 42; }
                    if (character.ToString() == "Q") { return 43; }
                    if (character.ToString() == "R") { return 44; }
                    if (character.ToString() == "S") { return 45; }
                    if (character.ToString() == "T") { return 46; }
                    if (character.ToString() == "U") { return 47; }
                    if (character.ToString() == "V") { return 48; }
                    if (character.ToString() == "W") { return 49; }
                    if (character.ToString() == "X") { return 50; }
                    if (character.ToString() == "Y") { return 51; }
                    if (character.ToString() == "Z") { return 52; }

                    return 0;
        }
        
    }
}