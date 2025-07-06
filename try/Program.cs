using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @try
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                else if (i % 7 == 0)
                {
                    continue;
                }
                Console.WriteLine("{0}", i);
            }
            Console.ReadLine();
        }
    }
}
