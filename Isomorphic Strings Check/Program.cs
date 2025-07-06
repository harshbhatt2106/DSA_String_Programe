using System;

namespace Isomorphic_Strings_Check
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter String1:");
            string input1 = Console.ReadLine();
            Console.Write("Enter String2:");
            string input2 = Console.ReadLine();

            bool Isomorphic = false;

            int i = 0, j = 0;

            while (i < input1.Length - 1 && j < input2.Length - 1)
            {
                if (input1[i] == input1[i + 1])
                {
                    if (input2[j] == input2[j + 1])
                    {
                        Isomorphic = true;
                        i += 2;
                        j += 2;
                    }
                    else
                    {
                        Isomorphic = false;
                        i += 2;
                        j += 2;
                    }
                }
                else if (input1[i] != input1[i + 1])
                {
                    if (input2[j] != input2[j + 1])
                    {
                        Isomorphic = true;
                        i++;
                        j++;
                    }
                    else
                    {
                        Isomorphic = false;
                        i += 2;
                        j += 2;
                    }
                }
                else
                {
                    Isomorphic = false;
                    i++;
                    j++;
                }
            }
            Console.WriteLine(Isomorphic);
            Console.ReadLine();

        }
    }
}
