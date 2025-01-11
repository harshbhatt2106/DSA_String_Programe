using System;

namespace Longest_Palindromic_Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //forgeeksskeegfor
            string value = "forgeeksskeegfor";
            string CurrentPelendrome;
            string LongestPelendrome = string.Empty;

            for (int i = 0; i < value.Length; i++)
            {
                for (int j = i + 1; j < value.Length; j++)
                {
                    if (MyClass.Ispelendrome(value, i, j))
                    {
                        CurrentPelendrome = value.Substring(i, j - i);
                        if (CurrentPelendrome.Length > LongestPelendrome.Length)
                        {
                            LongestPelendrome = CurrentPelendrome;
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
            end--;
            while (start < end)
            {
                if (input[start] != input[end])
                {
                    return false;
                }
                end--;
                start++;
            }
            return true;
        }
    }
}