using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Common_SubSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = "HARSHBHATT";
            string input2 = "HABSBHATT";
            string answer = "";
            int index;
            for (int i = 0; i < input1.Length; i++)
            {
                index = i;
                string current = "";
                for (int j = 0; j < input2.Length; j++)
                {
                    if (index < input1.Length && input1[index] == input2[j])
                    {
                        current += input2[j];
                        index++;
                    }
                }
                if (current.Length > answer.Length)
                {
                    answer = current;
                }
            }
            Console.WriteLine(answer);
            Console.ReadLine();

        }
    }
}
