using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountPelendromik_Strings
{
    internal class Program
    {
        public static bool Ispelendrome(string input)
        {
            bool Ispelendrome = true;
            for (int i = 0; i < input.Length / 2; i++)
            {
                if (input[i] != input[input.Length - i - 1])
                {
                    Ispelendrome = false;
                }
            }
            return Ispelendrome;
        }

        static void Main(string[] args)
        {
            string Input = "harsh";
            int count = 0;
            string concatestring = "";
            int len = Input.Length;

            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    concatestring = "";
                    concatestring += Input[i];
                    concatestring += Input[j];
                    concatestring += Input[i];
                    if (Program.Ispelendrome(concatestring))
                    {
                        count++;
                    }

                    Console.WriteLine(concatestring);
                }
            }
            Console.WriteLine(count);


            Console.ReadLine();
        }
    }
}
