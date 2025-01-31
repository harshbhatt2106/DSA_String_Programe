using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Word_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dictonary = { "i", "Like", "sam", "sung" };
            string input = "Likesam";
            bool Is = false;
            int index = 0;
            int IterationCount = 1;
            bool WordFound = false;

            for (int i = 0; i < dictonary.Length; i++)
            {
                WordFound = false;
                foreach (var item in dictonary[i])
                {
                    if (input.Length > index)
                    {
                        if (item == input[index])
                        {
                            WordFound = true;
                            index++;
                        }
                    }
                }
                if (WordFound)
                {
                    if (IterationCount==2 && WordFound)
                    {
                        Is = true;
                        break;
                    }
                    IterationCount++;
                }
            }

            if (Is)
            {
                Console.WriteLine("yes");
            }
            else Console.WriteLine("no");

            Console.ReadLine();
        }
    }
}
