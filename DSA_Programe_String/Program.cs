using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revers_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter String:");
            string str = Console.ReadLine();
            Console.WriteLine(myclass.Revers(str));
            Console.ReadLine();
        }
    }
    static class myclass
    {
        public static string Revers(string value)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = value.Length - 1; i >= 0; i--)
            {
                stringBuilder.Append(value[i]);
            }
            return stringBuilder.ToString();
        }
    }
}
