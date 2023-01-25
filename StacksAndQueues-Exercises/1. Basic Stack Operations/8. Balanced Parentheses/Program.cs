using System;
using System.Collections.Generic;

namespace _8._Balanced_Parentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string parentheses = Console.ReadLine();
            Stack<char> chars = new Stack<char>(); 

            for (int i = 0; i < parentheses.Length; i++)
            {
                switch (parentheses[i])
                {
                    case'(':
                        chars.Push('(');
                        break;
                    case '{':
                        chars.Push('{');
                        break;
                    case '[':
                        chars.Push('[');
                        break;
                    case ')':
                        if (chars.Count==0 || chars.Pop()!='(')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                    case '}':
                        if (chars.Count == 0 || chars.Pop() != '{')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                    case ']':
                        if (chars.Count == 0 || chars.Pop() != '[')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                }
            }
            Console.WriteLine("YES");
        }
    }
}
