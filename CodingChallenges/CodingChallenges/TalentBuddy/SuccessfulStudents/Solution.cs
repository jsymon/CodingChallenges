using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.TalentBuddy.SuccessfulStudents
{
    class Solution
    {
        public void count_successful_students(int[] grades, int min_grade)
        {
            Console.WriteLine(grades.Count(a => a >= min_grade));
        }
    }
}
