using System;

namespace Pelendrome_Or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string abc = "shhd";
            bool a = MyClass.Ispelendrome(abc, abc.Length);
            if (a)
            {
                Console.WriteLine("Pelendrome");
            }
            else
            {
                Console.WriteLine("not pelendrome");
            }
            Console.ReadLine();
        }
    }
    public static class MyClass
    {
        public static bool Ispelendrome(string value, int len)
        {
            for (int i = 0; i < len / 2; i++)
            {
                if (value[i] != value[len - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
