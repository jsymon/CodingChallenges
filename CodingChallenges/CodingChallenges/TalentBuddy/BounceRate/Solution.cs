using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.TalentBuddy.BounceRate
{
    class Solution
    {
        public void compute_active_users(int n, int b)
        {
            Console.WriteLine(n * (100 - b) / 100);
        }
    }
}
