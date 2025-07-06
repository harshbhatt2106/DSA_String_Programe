using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_first_repeated_word_in_a_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string ");
            string Input = Console.ReadLine();

            string word = string.Empty;
            string temp = string.Empty;

            int j;
            for (int i = 0; i < Input.Length; i++)
            {
                for (j = i; j < Input.Length; j++)
                {
                    char c = Input[j];
                    if (c != ' ')
                    {
                        word += c;
                    }
                    else
                    {
                        break;
                    }
                }
                i = j;
                for (int k = j; k < Input.Length; k++)
                {
                    char c = Input[k];
                    if (c == ' ')
                    {
                        temp = string.Empty;
                    }
                    else
                    {
                        temp += c;
                    }
                    if (word == temp)
                    {
                        Console.WriteLine(word);
                        break;
                    }
                }
                word = string.Empty;
            }
            Console.ReadLine();
        }
    }
}
