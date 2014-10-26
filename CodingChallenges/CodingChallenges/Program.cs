using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    class Program
    {
        static void Main(string[] args)
        {




            int loops = 3;
            int a = 10;
            int b = 100;

            for (int i = 0; i <= loops; i++)//i us total quantity of 'a' to take
            {
                var aMax = (loops - i) * a;
                var bMax = i * b;

                Console.WriteLine(aMax + bMax);

            }












            //TestChocolateFeast();
            //TestHalloweenParty();
            //TestCommonCourses();
            //TestSortingStudents();
            //TestPriority();
            //TestMaximizingXOR();
            //TestLoveLetterMystery();
            //TestServiceLane();
            //TestUtopianTree();
            Console.Read();
        }

        private static void TestChocolateFeast()
        {
            var chocolateTransaction = new CodingChallenges.HackerRank.ChocolateFeast.ChocolateTransaction() { MoneyInPocket = 6, ChocolatePrice = 2, WrapperToFreeChocolateRatio = 2 };
            new CodingChallenges.HackerRank.ChocolateFeast.Solution().PrintOutput(chocolateTransaction);
        }

        private static void TestHalloweenParty()
        {
            new HackerRank.HalloweenParty.Solution();
        }

        private static void TestCommonCourses()
        {
            new TalentBuddy.CommonCourses.Solution().get_common_courses(new[] { 8, 3, 1, 2, 9, 5, 6 }, new[] { 6, 5, 4, 3, 2, 1 });
        }

        private static void TestSortingStudents()
        {
            new TalentBuddy.SortingStudents.Solution().sort_students(new[] { 16, 7, 3, 9 });
        }

        private static void TestPriority()
        {
            new TalentBuddy.Priority.Solution().count_configurations(1, 1, 1, 2);
        }

        private static void TestMaximizingXOR()
        {
            new HackerRank.MaximizingXOR.Solution().PrintOutput(10, 15);
        }

        private static void TestLoveLetterMystery()
        {
            var llm = new HackerRank.TheLoveLetterMystery.Solution();
            llm.CalculateLetterChanges("nabm");
        }

        private static void TestServiceLane()
        {
            var sl = new HackerRank.ServiceLane.Solution()
            {
                LaneActions = new int[,] {
                    { 2, 3 },
                    { 1, 4 },
                    { 2, 4 },
                    { 2, 4 },
                    { 2, 3 }
                },
                LaneRestrictions = new[] { 1, 2, 2, 2, 1 }
            };
            sl.PrintOutput();
        }

        private static void TestUtopianTree()
        {
            var results = new HackerRank.UtopianTree.Solution().GetOutputs(new[] { 3, 4 });
        }
    }
}
