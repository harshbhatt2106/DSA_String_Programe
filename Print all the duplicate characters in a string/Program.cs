using System;

namespace Print_all_the_duplicate_characters_in_a_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string ");
            string a = Console.ReadLine();
            char[] name = a.ToCharArray();
            int count = 1;
            for (int i = 0; i < name.Length; i++)
            {
                char word = name[i];
                if (word != '-')
                {
                    for (int j = i + 1; j < name.Length; j++)
                    {
                        if (word == name[j])
                        {
                            name[j] = '-';
                            name[i] = '-';
                            count++;
                        }
                    }
                    Console.WriteLine(" " + word + " " + count);
                }
                count = 1;
            }
            Console.ReadLine();
        }

    }
}
