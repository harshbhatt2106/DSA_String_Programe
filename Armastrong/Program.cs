using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        var number = Console.ReadLine();
        var temp = 0;
        var digit=int.MinValue;

        for (int i = 0; i < number.Length; i++)
        {
            digit = number[i] - '0';
            temp += digit * digit * digit;
        }

        if (number == temp.ToString())
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
        Console.ReadLine();
    }
}
