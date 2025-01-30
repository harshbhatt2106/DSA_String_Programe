using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Longest_Recurring_Subsequence_in_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = "AABEBCDD";
            int LongestSubstringCount = 0;
            int count = 0;

            for (int i = 0; i < value.Length; i++)
            {
                for (int j = i+1; j < value.Length; j++)
                {
                    if (value[i] == value[j])
                    {
                        LongestSubstringCount++;
                    }
                }
            }
           
            Console.WriteLine(LongestSubstringCount);
            Console.ReadLine();
        }
    }
}
