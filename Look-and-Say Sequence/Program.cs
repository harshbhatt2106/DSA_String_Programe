using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Look_and_Say_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1, 11, 21, 1211, 111221, 312211, 13112221, 1113213211 
            string number = "11";
            Console.Write("Enter element:");
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                number = "1";
                return;
            }
            if (n == 2)
            {
                number = "11";
                return;
            }

            int count = 1;
            string temp = "";

            for (int i = 3; i <= n; i++)
            {
                for (int j = 1; j < number.Length; j++)
                {
                    if (number[j] == number[j - 1])
                    {
                        count++;
                    }
                    else
                    {
                        temp += count.ToString() + number[j - 1];
                        count = 1;
                    }
                }
                temp += count.ToString() + number[number.Length - 1];
                number = temp;
                temp = "";
                count = 1;
            }
            Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}