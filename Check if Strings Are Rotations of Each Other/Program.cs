using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Check_if_Strings_Are_Rotations_of_Each_Other
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string one = "aab";
            string two = "aba";

            bool flag = false;

            char[] arr = one.ToCharArray();
            char[] two2 = two.ToCharArray();

            for (int i = 0; i < one.Length; i++)
            {
                if (two == new string(arr))
                {
                    flag = true;
                    break;
                }
                char temp = arr[arr.Length - 1];
                for (int j = arr.Length - 1; j > 0; j--)
                {
                    arr[j] = arr[j - 1];
                }
                arr[0] = temp;
            }
            if (flag)
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
