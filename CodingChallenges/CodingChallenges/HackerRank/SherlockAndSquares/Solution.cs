using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.HackerRank.SherlockAndSquares
{
    class Solution
    {
        public Solution()
        {
            var inputs = ParseInputs();
            for (int i = 0; i < inputs.GetLength(0); i++)
            {
                int start = inputs[i][0];
                int end = inputs[i][1];

                var a = Math.Ceiling(Math.Sqrt(start));
                var b = Math.Floor(Math.Sqrt(end)) + 1;
                Console.WriteLine(b - a);
            }
        }

        private static int[][] ParseInputs()
        {
            var d1Length = Int32.Parse(Console.ReadLine());
            var matrix = new int[d1Length][];
            for (int i = 0; i < d1Length; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(a => Int32.Parse(a))
                    .ToArray();
            }
            return matrix;
        }
    }
}
