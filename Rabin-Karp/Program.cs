using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabin_Karp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Input = "HARSH BHATT HARSH";
            string Find = "HAR";

            bool IsFind = false;
            int MatchIndex = 0;
            int index = 0;

            for (int i = 0; i < Input.Length; i++)
            {
                IsFind = false;
                index = i;
                for (int j = 0; j < Find.Length; j++)
                {
                    if (Input[index] == Find[j])
                    {
                        IsFind = true;
                        MatchIndex = i;
                        if (i < Input.Length - 1)
                        {
                            index++;
                        }
                    }
                    else
                    {
                        IsFind = false;
                        MatchIndex = 0;
                        break;
                    }
                }
                if (IsFind)
                {
                    Console.WriteLine(MatchIndex);
                }
            }
            Console.ReadLine();
        }
    }
}
