using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.HackerRank.SherlockAndGCD
{
    class Solution
    {
        public Solution()
        {
            var testCases = new int[Int32.Parse(Console.ReadLine())][];
            for (int i = 0; i < testCases.GetLength(0); i++)
            {
                GetInput(testCases, i);
                bool divides = false;
                for (int j = 2; j <= 100000; j++)
                {
                    if (testCases[i].All(a => a % j == 0)) //GCD - greatest common divisor found
                    {
                        divides = true;
                        break;
                    }
                }
                Console.WriteLine(divides ? "NO" : "YES");
            }
        }

        private static void GetInput(int[][] testCases, int i)
        {
            Console.ReadLine();//dummy we don't need this, just clear this buffer from the line
            //var size = Int32.Parse(Console.ReadLine());
            testCases[i] =
                Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(a => Int32.Parse(a))
                .ToArray();
        }
    }
}
