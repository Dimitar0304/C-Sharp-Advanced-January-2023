using System;
using System.Collections.Generic;

namespace _9._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            string textBeforeLastChange = string.Empty;
            string text = string.Empty;
            Stack<string> changes = new Stack<string>();
            
            //we recive empty text and we recive commands that manipulating the text
            //first line we recive count of commands that we recive
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] command = Console.ReadLine().Split();
                switch (command[0])
                {
                    case "1":
                        string textToAdd = command[1];
                        changes.Push(textToAdd);
                        text += textToAdd;

                        break;
                    case "2":
                        
                        changes.Push(text);
                        int countToRemove = int.Parse(command[1]);
                        text = text.Remove(text.Length- countToRemove);
                        break;
                    case "3":
                        int indexToReturn = int.Parse(command[1])-1;
                        Console.WriteLine(text[indexToReturn]);
                        break;
                    case "4":
                        text = changes.Pop();
                        break;
                }
            }
            //1 command - someString appends on the end of text.
            //2 - count of delete chars of current text from end to start of text
            //3 index - returns in that index wich is consist char
            //4 is undo last operation where theirs type are 1 or 2 and returns text before operation.
        }
    }
}
