using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Shortest_Superstring_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = { "harsh", "har", "hbhatt" };
            string join = string.Empty;
            bool IsFind = false;
            for (int i = 0; i < array.Length; i++)
            {
                foreach (char item in array[i])
                {
                    IsFind = false;
                    if (join == string.Empty)
                    {
                        join = join + item;
                    }
                    for (int j = 0; j < join.Length; j++)
                    {
                        if (join[j] == item)
                        {
                            IsFind = true;
                            break;
                        }
                    }
                    if (!IsFind)
                    {
                        join += item;
                    }
                }
            }
            Console.WriteLine(join);
            Console.ReadLine();
        }
    }
}
