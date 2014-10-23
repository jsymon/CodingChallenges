using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.TalentBuddy.StudentProgress
{
    class Solution
    {
        public void longest_improvement(int[] grades)
        {
            if (grades.Length < 2)
                Console.WriteLine(grades.Length); //minimal or zero streak - using 'grades.Length' is a tiny bit hacky but will always result in a correct answer.
            else
            {
                int bestStreak = 1;
                int currentStreak = 1;
                if (grades.Length > 1)
                {
                    for (int i = 1; i < grades.Length; i++)
                    {
                        if (grades[i - 1] > grades[i])//if previous grade was a greater number than *current* grade, then that streak is over
                        {
                            currentStreak = 1;
                        }
                        else
                        {
                            currentStreak++;
                            bestStreak = currentStreak > bestStreak ? currentStreak : bestStreak;
                        }
                    }
                }
                Console.WriteLine(bestStreak);
            }
        }
    }
}