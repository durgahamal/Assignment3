using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Assignment3
{
    class Assignq3
    {
        public static void Longestword()
        {
            Console.WriteLine("space separated string");
            string sentence = "Write a csharp program to dispaly the following pattern using the alphabet";
            string[] words = sentence.Split(" ");
            foreach(string text in words)
            Console.WriteLine(text);
            Console.ReadLine();
            
            







        }
    }
}
