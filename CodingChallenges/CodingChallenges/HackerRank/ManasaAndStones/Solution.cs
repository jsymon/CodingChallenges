using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.HackerRank.ManasaAndStones
{
    class Solution
    {
        public Solution()
        {
            var configs = ParseInputs();
            foreach (var config in configs)
            {
                var totals = new List<int>();
                int a = config.StoneIncrements[0];
                int b = config.StoneIncrements[1];

                for (int i = 0; i <= config.NumberOfStones - 1; i++)//i is total quantity of 'a' to take
                {
                    var aMax = ((config.NumberOfStones - 1) - i) * a;
                    var bMax = i * b;
                    totals.Add(aMax + bMax);
                }
                Console.WriteLine(string.Join(" ", totals.Distinct().OrderBy(x => x).ToList()));
            }
        }

        private ManasaStoneConfig[] ParseInputs()
        {
            var configs = new ManasaStoneConfig[Int32.Parse(Console.ReadLine())];
            for (int i = 0; i < configs.Length; i++)
            {
                var config = new ManasaStoneConfig();
                config.NumberOfStones = Int32.Parse(Console.ReadLine());
                config.StoneIncrements = new int[] { Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()) };
                configs[i] = config;
            }
            return configs;
        }
    }

    class ManasaStoneConfig
    {
        public int NumberOfStones { get; set; }
        public int[] StoneIncrements { get; set; }
    }
}