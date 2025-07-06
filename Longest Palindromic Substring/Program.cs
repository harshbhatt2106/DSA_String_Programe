using System;

namespace Longest_Palindromic_Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = "harshlopolt";
            string CurrentPelendrome;
            string LongestPelendrome = string.Empty;

            for (int i = 0; i < value.Length; i++)
            {
                string temp = value[i].ToString();
                for (int j = i + 1; j < value.Length; j++)
                {
                    temp += value[j].ToString();
                    if (MyClass.Ispelendrome(value, i, j))
                    {
                        if (temp.Length > LongestPelendrome.Length)
                        {
                            LongestPelendrome = temp;
                        }
                    }
                }
            }
            Console.WriteLine("Longest Pelendrome:" + LongestPelendrome);
            Console.ReadLine();
        }
    }
    public static class MyClass
    {
        public static bool Ispelendrome(string input, int start, int end)
        {
            while (start<end)
            {
                if (input[start] != input[end])
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }
    }
}