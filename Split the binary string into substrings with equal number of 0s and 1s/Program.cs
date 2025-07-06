using System;

namespace Split_the_binary_string_into_substrings_with_equal_number_of_0s_and_1s
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string value = Console.ReadLine();
            int count = MaxsubString(value,value.Length);
            Console.WriteLine("Max Substring Count:"+count);
            Console.ReadLine();
        }
        static int MaxsubString(string input, int len)
        {
            int count0 = 0; 
            int count1 = 0;
            int MainCount = 0;
            for (int i = 0; i < len; i++)
            {
                if (count1 == count0)
                {
                    MainCount++;
                }
                if (input[i] == '0')
                {
                    count0++;
                }
                else
                {
                    count1++;
                }
            }
            if (count1 != count0)
            {
                return -1;
            }
            else
                return MainCount;
        }
    }

}
