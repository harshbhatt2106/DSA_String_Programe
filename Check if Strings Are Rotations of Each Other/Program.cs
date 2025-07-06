using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_Strings_Are_Rotations_of_Each_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "aba";
            string s2 = "aabc";
            StringBuilder stringBuilder1 = new StringBuilder(s2);

            char temp;
            bool IsRotate = false;

            for (int i = 1; i <= s1.Length; i++)
            {
                if (s1 == stringBuilder1.ToString())
                {
                    IsRotate = true;
                    break;
                }
                else
                {
                    temp = stringBuilder1[i-1];
                    stringBuilder1[i - 1] = stringBuilder1[i];
                    stringBuilder1[i] = temp;
                }
            }
            if (IsRotate)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            Console.ReadLine();

        }
    }
}
