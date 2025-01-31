using System;

namespace Print_all_subsequences_of_a_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = "Geeks";
            string concatestring = "";
            int len = value.Length;//5

            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len - i; j++)
                {
                    concatestring = "";
                    for (int k = j; k <= j + i; k++)
                    {
                        concatestring += value[k];
                    }
                    Console.WriteLine(concatestring);
                }
            }
            Console.ReadLine();
        }
    }
}
