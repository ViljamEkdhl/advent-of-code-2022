using System;
using System.Collections.Generic;
using System.Linq;

namespace aoc_2022;

public class Day4
{
    private readonly IEnumerable<string> input;

    public Day4(IEnumerable<string> input)
    {
        this.input = input;
        CalculateFirst();
    }


    private void CalculateFirst()
    {
        var sum = 0;
        foreach (var line in input)
        {
            var sign = line.IndexOf(",", StringComparison.Ordinal);
            var size = line.Length - sign - 1;
            if (IsContained(line.Substring(0, sign), line.Substring(sign + 1, size))) { sum++;};
        }
    }
    
    private bool IsContained(string elf1, string elf2)
    {
        var result = "";
        var firstNumber = elf1.Split('-');
        var secondNumber = elf2.Split('-');
        for (var i = 0; i < 2; i++)
        {
            var value = int.Parse(firstNumber[i]) - int.Parse(secondNumber[i]);
            switch (value)
            {
                case 0:
                    result += "0"; continue;
                case > 0:
                    result += "+"; continue;
                case < 0:
                    result += "-"; continue;
            }
        }
        return result is not ("++" or "--");
    }
}