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
            TestMaximizingXOR();
            //TestLoveLetterMystery();
            //TestServiceLane();
            //TestUtopianTree();
            Console.Read();
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
