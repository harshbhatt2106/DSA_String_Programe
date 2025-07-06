using System;

namespace Print_all_subsequences_of_a_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                string stringBuilder = string.Empty;
                for (int j = i; j < input.Length; j++)
                {
                    stringBuilder += input[j];
                    Console.WriteLine(stringBuilder);
                }
            }
            Console.ReadLine();
        }
    }
}
