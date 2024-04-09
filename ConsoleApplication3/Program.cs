using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> nums = new List<int>(Console.ReadLine().Split(' ').Select(x => int.Parse(x)));
            foreach (int i in nums)
            {
                List<int> ans = nums.FindAll(x => x == i);
                if (ans.Count >= 2)
                {
                    Console.WriteLine(true);
                    return;
                }
            }
            Console.WriteLine(false);
        }
    }
}