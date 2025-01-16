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
            string s2 = "aab";

            char temp;
            bool IsRotate = false;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1 == s2)
                {
                    IsRotate = true;
                    break;
                }
                else
                {
                    temp = s1[i];
                    s1 = temp + s1.Substring(0, s1.Length - 1);
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
