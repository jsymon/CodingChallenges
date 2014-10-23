using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.HackerRank.HalloweenParty
{
    class Solution
    {
        public Solution()
        {
            var rowCount = Int32.Parse(Console.ReadLine());
            var rows = new long[rowCount];
            for (int i = 0; i < rowCount; i++)
                rows[i] = long.Parse(Console.ReadLine());
            PrintOutput(rows);
        }

        private void PrintOutput(params long[] sliceCounts)
        {
            foreach (var sliceCount in sliceCounts)
            {
                if (sliceCount > 1)
                {
                    long x = sliceCount / 2;
                    long y = sliceCount - x;
                    long result = x * y;
                    Console.WriteLine(result);
                }
            }
        }
    }
}
