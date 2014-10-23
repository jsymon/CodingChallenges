using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.TalentBuddy.CommonCourses
{
    class Solution
    {
        public void get_common_courses(int[] courses1, int[] courses2)
        {
            //cheeky linq solution (i know...thats not the point of this exercise)
            //var sortedDuplicateCourses = courses1
            //    .Where(a => courses2.Any(b => b == a))
            //    .OrderBy(a => a);
            //Console.Write(string.Join(Environment.NewLine, sortedDuplicateCourses));

            var numbers = new List<int>();
            for (int i = 0; i < courses1.Length; i++)
            {
                for (int j = 0; j < courses2.Length; j++)
                {
                    if (courses1[i] == courses2[j])
                        numbers.Add(courses1[i]);
                }
            }
            sort_students(numbers);
        }

        private void sort_students(List<int> numbers)
        {
            bool changed = false;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i - 1] > numbers[i])
                {
                    int oldLeft = numbers[i - 1];//new right
                    numbers[i - 1] = numbers[i];
                    numbers[i] = oldLeft;
                    changed = true;
                }
            }
            if (changed)
                sort_students(numbers);
            else
                Console.WriteLine(string.Join(" ", numbers));
        }
    }
}