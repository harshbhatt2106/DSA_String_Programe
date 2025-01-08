using System;

namespace Print_all_the_duplicate_characters_in_a_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string ");
            string a = Console.ReadLine();
            Char[] name = a.ToCharArray();
            Array.Sort(name);

            int count = 1;

            for (int i = 0; i < name.Length; i++)
            {
                for (int j = i; j < name.Length - 1; j++)
                {
                    if (name[j] == name[j + 1])
                    {
                        count++;
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine(" " + name[i] + " " + count);
                count = 1;
            }
            Console.ReadLine();
        }
    }
}
