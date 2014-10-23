using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.TalentBuddy.SortingStudents
{
    //psuedo code example:
    /*
    bubblesort(A):
    repeat
        changed = false
        for i = 1 to length(A) - 1
            if A[i - 1] > A[i]
                swap A[i - 1], A[i]
                changed = true
    until not changed
    */
    class Solution
    {
        public void sort_students(int[] numbers)
        {
            bool changed = false;
            for (int i = 1; i < numbers.Length; i++)
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
