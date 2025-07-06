using System;

class Program
{
    static void Main()
    {
        string input = "a!!!b.c.d,e'f,ghi";
        char[] result = new char[input.Length];
        char[] letters = new char[input.Length];
        int count = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] >= 'a' && input[i] <= 'z')
            {
                letters[count] = input[i];
                count++;
            }
        }
        int revers = count - 1;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] >= 'a' && input[i] <= 'z')
            {
                result[i] = letters[revers--];
            }
            else
            {
                result[i] = input[i];
            }
        }

        string reversed = "";
        for (int i = 0; i < result.Length; i++)
        {
            reversed += result[i];
        }

        Console.WriteLine("Original : " + input);
        Console.WriteLine("Reversed : " + reversed);
        Console.ReadLine();
    }
}
