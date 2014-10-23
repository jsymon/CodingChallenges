using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.TalentBuddy.Priority
{
    class Solution
    {
        public void count_configurations(int a, int b, int c, int n)
        {
            int successCounter = 0;
            for (int _a = 0; _a <= a; _a++)
            {
                for (int _b = 0; _b <= b; _b++)
                {
                    for (int _c = 0; _c <= c; _c++)
                    {
                        if ((_a + _b + _c) == n)
                            successCounter++;
                    }
                }
            }
            Console.WriteLine(successCounter);
        }
    }
}
