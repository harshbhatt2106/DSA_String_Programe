using System;
using System.Text;

namespace Edit_Distance_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "sunday";
            StringBuilder string1 = new StringBuilder(a);
            string b = "saturday";

            if (a.Length == b.Length)
            {
                for (int i = 0; i < string1.Length; i++)
                {
                    if (b[i] != string1[i])
                    {
                        string1[i] = b[i];
                    }
                }
            }
            else
            {
                bool IsFound = false;
                for (int i = 0; i < string1.Length; i++)
                {
                    IsFound = false;
                    for (int j = 0; j < b.Length; j++)
                    {
                        if (string1[i] == b[j])
                        {
                            IsFound = true;
                            break;
                        }
                    }
                    if (!IsFound)
                    {
                        string1.Remove(i, 1);
                    }
                }
                for (int i = 0; i < b.Length; i++)
                {
                    if (i < string1.Length)
                    {
                        if (b[i] != string1[i])
                        {
                            string1[i] = b[i];
                        }
                    }
                    else
                    {
                        string1.Append(b[i]);
                    }
                }
            }
            Console.WriteLine(string1);
            Console.ReadLine();
        }
    }
}