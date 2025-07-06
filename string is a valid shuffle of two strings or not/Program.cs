using System;

namespace string_is_a_valid_shuffle_of_two_strings_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "pwwkew";
            int n = input.Length;

            string output = "";
            for (int i = 0; i < n; i++)
            {
                string temp = "";
                bool isFound = false;

                temp = input[i].ToString();

                for (int j = i + 1; j < n; j++)
                {
                    foreach (var item in temp)
                    {
                        if (item == input[j])
                        {
                            isFound = true;
                            break;
                        }
                    }
                    if (!isFound)
                    {
                        temp += input[j];
                    }
                    if (temp.Length > output.Length)
                    {
                        output = temp;
                    }
                }
            }
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
