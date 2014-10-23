using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.HackerRank.CutTheSticks
{
    class Solution
    {
        public Solution()
        {
            var inputs = GetInputs();
            PrintOutput(inputs);
        }

        private int[] GetInputs()
        {
            Console.ReadLine();//clear first line of buffer - we don't need this
            return Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(a => Int32.Parse(a))
                .ToArray();
        }
        private void PrintOutput(int[] inputs)
        {
            //print total sticks
            Console.WriteLine(inputs.Length);

            //apply chop!
            var minHeight = inputs.Min();
            inputs = inputs
                .Where(a => a - minHeight > 0)
                .ToArray();
            if (inputs.Length > 0)
            {
                PrintOutput(inputs);
            }
        }
    }
}
