using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.TalentBuddy.Prediction
{
    class Solution
    {
        public void compute_prediction(int n, int w)
        {
            decimal _n = n;
            for (int i = 0; i < w; i++)
                _n *= 1.07m;
            Console.WriteLine(_n);
        }
    }
}
