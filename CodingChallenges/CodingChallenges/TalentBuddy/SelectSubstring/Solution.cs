using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.TalentBuddy.SelectSubstring
{
    class Solution
    {
        public void select_substring(string s, int p1, int p2)
        {
            //Simple solution using inbuilt string functions...I think this may be missing the point of this task though!
            //Console.WriteLine(s.Substring(p1 - 1, p2 - (p1 - 1)));

            var sb = new StringBuilder();
            for (int i = p1 - 1; i < p2; i++)
                sb.Append(s[i]);
            Console.WriteLine(sb.ToString());
        }
    }
}
