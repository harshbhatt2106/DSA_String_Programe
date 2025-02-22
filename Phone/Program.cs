using System;
namespace Phone
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //string[] words = { "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz", };
            //int count = 0;
            //string input = "geeksforgeeks";
            //int index = 0;

            //foreach (var itema in input)
            //{
            //    for (int i = 0; i < words.Length; i++)
            //    {
            //        foreach (var item in words[i])
            //        {
            //            count++;
            //            if (index < input.Length)
            //            {
            //                if (item == input[index])
            //                {
            //                    index++;
            //                    for (int j = 0; j < count; j++)
            //                    {
            //                        Console.Write(i + 1 + 1);
            //                    }
            //                }
            //            }
            //        }
            //        count = 0;
            //    }
            //}
            string[] str
          = { "2",    "22",  "222", "3",   "33", "333",
                "4",    "44",  "444", "5",   "55", "555",
                "6",    "66",  "666", "7",   "77", "777",
                "7777", "8",   "88",  "888", "9",  "99",
                "999",  "9999" };

            Console.WriteLine("Enter string");

            string input = Console.ReadLine();
            string output = "";
            int position;

            int n = input.Length;
            for (int i = 0; i < n; i++)
            {
                position = input[i] - 'A';
                output = output + str[position];
                position = 0;
            }
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
