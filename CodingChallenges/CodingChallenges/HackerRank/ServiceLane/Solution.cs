using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.HackerRank.ServiceLane
{
    class Solution
    {
        public Solution() { }

        public int[] LaneRestrictions { get; set; }

        public int[,] LaneActions { get; set; }
        public void Solve()
        {
            PopulateData();
            PrintOutput();
        }

        private void PopulateData()
        {
            //read the first line of input - this contains two items, separated by a space
            var dimensions = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            PopulateLaneRestrictions(Int32.Parse(dimensions[0]));
            PopulateLaneActions(dimensions);
        }

        private void PopulateLaneRestrictions(int laneRestrictionCount)
        {
            //the first item on the first line contains the maximum width of each lane - i.e. the size of the array
            //this is commented out because we really dont need it.
            //_laneRestrictions = new int[laneRestrictionCount];

            //each subsequent item on the *next* (second) row contains the max size of vehicle in each lane (a number between 1 and 3)
            LaneRestrictions = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(a => Int32.Parse(a))
                .ToArray();
        }

        private void PopulateLaneActions(string[] dimensions)
        {
            //the second item on the first line contains the number of test cases (lane movements - start and end index)
            LaneActions = new int[Int32.Parse(dimensions[1]), 2];
            for (int i = 0; i < LaneActions.GetLength(0); i++)
            {
                //each lane action contain
                var laneAction = Console.ReadLine()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(a => Int32.Parse(a))
                    .ToArray();
                LaneActions[i, 0] = laneAction[0];
                LaneActions[i, 1] = laneAction[1];
            }
        }

        public void PrintOutput()
        {
            for (int i = 0; i < LaneActions.GetLength(0); i++)
            {
                int startIndex = LaneActions[i, 0];
                var endIndex = LaneActions[i, 1];
                var minimum = LaneRestrictions
                        .Skip(startIndex)//the start of the lane
                        .Take((endIndex - startIndex) + 1) //the number of movements - +1 is necessary as we are counting inclusively
                        .Min();//the smallest lane width (between 1 and 3)
                Console.WriteLine(minimum);
            }
        }
    }
}
