using System;

namespace Minimum_number_of_bracket_reversals_needed_to_make_an_expression_balanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "{{{}";
            int state = 0;
            int count = 0;
            int revers = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '{')
                {
                    state++;
                }
                else revers++;
            }

            for (int i = 0; i < state + revers; i++)
            {
                if (state == revers)
                {
                    break;
                }
                else if (state > revers)
                {
                    state--;
                    revers++;
                    count++;
                }
                else
                {
                    count++;
                    state++;
                    revers--;
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
