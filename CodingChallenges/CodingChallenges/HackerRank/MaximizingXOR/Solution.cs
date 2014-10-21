using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.HackerRank.MaximizingXOR
{
    class Solution
    {
        public Solution() { }

        public void Solve()
        {
            int l = Int32.Parse(Console.ReadLine());
            int r = Int32.Parse(Console.ReadLine());
            PrintOutput(l, r);
        }

        public void PrintOutput(int l, int r)
        {
            int maximum = 0;

            for (int i = l; i <= r; i++)//outer loop
            {
                for (int j = i; j <= r; j++) //interesting! to avoid any repeated sequences, each time we begin this inner loop our start index begins at the outerloop variable.
                {
                    int xor = i ^ j;
                    maximum = xor > maximum ? xor : maximum;
                }
            }
            Console.WriteLine(maximum);
        }
    }
}
