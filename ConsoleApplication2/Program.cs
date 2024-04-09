using System;
using System.Collections.Generic;

class Program
{
    static List<List<int>> CombinationSum(int[] candidates, int target)
    {
        Array.Sort(candidates);
        var result = new List<List<int>>();
        Backtrack(candidates, target, 0, new List<int>(), result);
        return result;
    }

    static void Backtrack(int[] candidates, int target, int start, List<int> path, List<List<int>> result)
    {
        if (target == 0)
        {
            result.Add(new List<int>(path));
            return;
        }

        if (target < 0)
            return;

        for (int i = start; i < candidates.Length; i++)
        {
            if (i > start && candidates[i] == candidates[i - 1])
                continue;
            
            path.Add(candidates[i]);
            Backtrack(candidates, target - candidates[i], i + 1, path, result);
            path.RemoveAt(path.Count - 1);
        }
    }

    static void Main(string[] args)
    {
        int[] candidates = { 1, 1, 3};
        int target = 2;
        var combinations = CombinationSum(candidates, target);
        
        foreach (var combination in combinations)
        {
            Console.WriteLine(string.Join(", ", combination));
        }
    }
}