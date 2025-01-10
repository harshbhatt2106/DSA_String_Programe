using System;

public class Program
{
    // Function to check if String A is a shuffled substring of String B
    static bool IsShuffledSubstring(string A, string B)
    {
        int alen = A.Length;
        int blen = B.Length;

        if (alen > blen)
            return false;

        A = SortString(A);

        for (int i = 0; i <= alen - blen; i++)
        {
            string subString = B.Substring(i, blen);

            subString = SortString(subString);

            if (subString.Equals(A))
                return true;
        }

        return false;
    }

    // Method to sort a string alphabetically
    static string SortString(string inputString)
    {
        char[] tempArray = inputString.ToCharArray();
        Array.Sort(tempArray);
        return new string(tempArray);
    }

    // Main function to test the implementation
    public static void Main(string[] args)
    {
        // Input strings
        string str1 = "geekforgeeks";
        string str2 = "ekegorfkeegsgeek";

        // Check if str1 is a shuffled substring of str2
        bool result = IsShuffledSubstring(str1, str2);

        // Output the result
        Console.WriteLine(result ? "YES" : "NO");
    }
}
