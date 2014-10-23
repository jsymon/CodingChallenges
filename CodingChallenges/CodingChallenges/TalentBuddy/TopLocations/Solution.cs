using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.TalentBuddy.TopLocations
{
    class Solution
    {
        public void sort_locations(int a, int b, int c)
        {
            string output = string.Join(" ", new[] { a, b, c }.OrderBy(i => i));
            Console.WriteLine(output);
        }
    }
}
