using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.HackerRank.TheLoveLetterMystery
{
    class Solution
    {
        public string[] PrePalindromeLines { get; set; }
        public Solution() { }
        public void Solve()
        {
            PopulateData();
            PrintOutput();
        }

        private string[] PopulateData()
        {
            PrePalindromeLines = new string[Int32.Parse(Console.ReadLine())];
            for (int i = 0; i < PrePalindromeLines.Length; i++)
            {
                PrePalindromeLines[i] = Console.ReadLine();
            }
            return PrePalindromeLines;
        }
        private void PrintOutput()
        {
            foreach (var prePalindromeLine in PrePalindromeLines)
            {
                var changeCount = CalculateLetterChanges(prePalindromeLine);
                Console.WriteLine(changeCount);
            }
        }

        public int CalculateLetterChanges(string word)
        {
            int wordDifference = 0;
            //split word into two halves - if it's an odd number that's fine as it can be ignored.
            string leftHalf = word.Substring(0, word.Length / 2);
            string rightHalf = word.Substring(word.Length - (word.Length / 2));

            //calculate the difference between the corresponding first and last characters - note we could reverse 'rightHalf' to make things more readable but these is not the most performant way!
            for (int i = 0; i < rightHalf.Length; i++)
            {
                byte charDifference = 0;

                char leftChar = leftHalf[i];
                char rightChar = rightHalf[rightHalf.Length - (1 + i)];

                byte bLeftChar = (byte)leftChar;
                byte bRightChar = (byte)rightChar;

                if (bRightChar > bLeftChar)
                {
                    charDifference = (byte)(bRightChar - bLeftChar);
                }
                else if (bLeftChar > bRightChar)
                {
                    charDifference = (byte)(bLeftChar - bRightChar);
                }
                wordDifference += charDifference;
            }
            return wordDifference;
        }
    }
}