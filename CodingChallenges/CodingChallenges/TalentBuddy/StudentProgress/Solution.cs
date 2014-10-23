using System;
using System.Collections.Generic;
using System.Linq;  
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.TalentBuddy.LongestImprovement
{
    class Solution
    {
        public void is_sorted(int[] grades)
        {
            bool isOk = true;
            if (grades.Length > 1)
            {
                for (int i = 1; i < grades.Length; i++)
                    if (grades[i - 1] > grades[i])
                    {
                        isOk = false;
                        break;
                    }
            }
            Console.WriteLine(isOk ? 1 : 0);
        }
    }
}
