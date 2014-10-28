using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.HackerRank.ProjectEuler
{
    class _005SmallestMultiple
    {
    public _005SmallestMultiple()
    {
        var inputs = GetInputs();
        foreach (var maxNumber in inputs)
        {
            int minDivisible = GetMinDivisible(maxNumber);
            Console.WriteLine(minDivisible);
        }
    }

    private byte[] GetInputs()
    {
        var testCases = Byte.Parse(Console.ReadLine());//clear first buffer
        var maxNumbers = new byte[testCases];
        for (int i = 0; i < testCases; i++)
            maxNumbers[i] = byte.Parse(Console.ReadLine());
        return maxNumbers;
    }

    private static int GetMinDivisible(byte maxNumber)
    {
        var range = Enumerable.Range(1, maxNumber);
        for (int i = maxNumber; true; i++)
        {
            if (range.All(a => i % a == 0))
            {
                return i;
            }
        }
    }
    }
}
