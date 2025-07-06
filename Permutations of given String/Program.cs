using System;

namespace Permutations_of_given_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter String:");
            string value = Console.ReadLine();
            
            char[] charArray = value.ToCharArray();
            char temp;
            
            for (int i = 0; i < value.Length; i++)
            {
                for (int j = 1; j < value.Length; j++)
                {
                    Console.WriteLine(charArray);
                    temp = charArray[j];
                    charArray[j] = charArray[j - 1];
                    charArray[j - 1] = temp;
                }
            }
            Console.ReadLine();
        }
    }
}
