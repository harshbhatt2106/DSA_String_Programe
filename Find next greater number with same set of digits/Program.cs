using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Find_next_greater_number_with_same_set_of_digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string digit = "231";
            char[] a = digit.ToCharArray();
            char temp;
            int index = 0;
            bool IsPossible = false;
            for (int i = 1; i < a.Length; i++)
            {
                if (a[a.Length - 1] > a[a.Length - 1 - i])
                {
                    temp = a[a.Length - 1];
                    a[a.Length - 1] = a[a.Length - i - 1];
                    a[a.Length - i - 1] = temp;
                    index = a.Length - i - 1;
                    IsPossible = true;
                    break;
                }
            }
            if (!IsPossible)
            {
                Console.WriteLine("Its not Possible");
            }
            else
            {
                Array.Reverse(a, index + 1, a.Length - index - 1);
                Console.WriteLine(a);
            }
            Console.ReadLine();

        }
    }
}
