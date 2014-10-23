using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.HackerRank
{
    /// <summary>
    /// Hacker Rank reusable code
    /// </summary>
    public class Functions
    {
        public void GetInputPerRow()
        {
            //line 1 always contains the number of records
            var items = new int[Int32.Parse(Console.ReadLine())];
            for (int i = 0; i < items.Length; i++)
            {
                //each subsequent row represents a new item
                items[i] = Int32.Parse(Console.ReadLine());
            }
        }
    }
}
