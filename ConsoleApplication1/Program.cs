using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            char[] J = Console.ReadLine().ToArray();
            char[] S = Console.ReadLine().ToArray();
            int count = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (J.Contains(S[i])) count++;
            }
            Console.WriteLine(count);   
        }
    }
}