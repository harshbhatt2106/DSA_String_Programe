using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valid_Parentheses_in_an_Expression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");

            string input = Console.ReadLine();

            Stack<char> stack = new Stack<char>();
            
            
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(' || input[i] == '[' || input[i] == '{')
                {
                    stack.Push(input[i]);
                }
            }
            for (int i = 0; i < input.Length; i++)
            {
                if(stack.Count > 0)
                {
                    if (stack.Peek() == '(' && input[i] == ')' ||
                        stack.Peek() == '{' && input[i] == '}' ||
                        stack.Peek() == '[' && input[i] == ']')
                    {
                        stack.Pop();
                    }
                }
            }
            if (stack.Count == 0)
            {
                Console.WriteLine("balanced");
            }
            else Console.WriteLine("Not balance");


            Console.ReadLine();
        }
    }
}
