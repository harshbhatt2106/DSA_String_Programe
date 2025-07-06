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
            string Input = "THIS IS A TEST TEXT";
            string Find = "TEST";

            bool IsFind = false;
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
                        if (i < Input.Length - 1)
                        {
                            index++;
                        }
                    }
                    else
                    {
                        IsFind = false;
                        break;
                    }
                }
                if (IsFind)
                {
                    IsFind = true;
                    Console.WriteLine(i);
                    break;
                }
            }

            if (!IsFind)
            {
                Console.WriteLine("String not found");
            }
            Console.ReadLine();
        }
    }
}
