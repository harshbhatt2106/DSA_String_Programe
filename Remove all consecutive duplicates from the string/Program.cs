using System;

namespace Remove_all_consecutive_duplicates_from_the_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Input = "aaabbbcccdd";
            string output = string.Empty;
            for (int i = 0; i < Input.Length; i++)
            {
                if (i == 0)
                {
                    output += Input[i];
                }
                else if (Input[i] != Input[i - 1])
                {
                    output += Input[i];
                }
            }
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
