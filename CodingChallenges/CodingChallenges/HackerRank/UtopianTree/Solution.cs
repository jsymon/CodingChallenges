using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.HackerRank.UtopianTree
{
    /// <summary>
    /// The Utopian tree goes through 2 cycles of growth every year. 
    /// The first growth cycle occurs during the spring, when it doubles in height. 
    /// The second growth cycle occurs during the summer, when its height increases by 1 meter. 
    /// </summary>
    class Solution
    {
        public Solution() { }

    private void Solve()
    {
        var inputs = GetInputs();
        var outputs = GetOutputs(inputs);
        foreach (var output in outputs)
            Console.WriteLine(output);
    }

    private int[] GetInputs()
    {
        //line 1 always contains the number of records
        var inputs = new int[Int32.Parse(Console.ReadLine())];
        for (int i = 0; i < inputs.Length; i++)
        {
            //each subsequent row represents a new item
            inputs[i] = Int32.Parse(Console.ReadLine());
        }
        return inputs;
    }
    public int[] GetOutputs(int[] inputs)
    {
        var stages = Enumerable.Range(0, inputs.Max() + 1).ToArray();
        for (int i = 0; i < stages.Length; i++)
        {
            var cycleResult = CalculateHeight(i == 0 ? 0 : stages[i - 1], i);
            stages[i] = cycleResult;
        }
        return inputs.Select(index => stages[index]).ToArray();
    }

    private int CalculateHeight(int currentHeight, int cycleIndex)
    {
        if (cycleIndex % 2 == 0)//summer - height increases by 1 meter
        {
            return currentHeight + 1;
        }
        else//spring - height doubles
        {
            return currentHeight * 2;
        }
    }
    }
}
