using System;
using System.Collections.Generic;

class Program {
    public static void Main(string[] args)
    {
        int[] line1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int[] line2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int m = line1[1];
        
        var result = new List<int>();
        Combination(line2, new bool[line2.Length], 0, 3, result);
    
        result.Sort((int a, int b) => { return b.CompareTo(a); });
        foreach (int item in result)
        {
            if (item <= m)
            {
                Console.WriteLine(item);
                break;
            }
        }
    }

    public static void Combination(int[] list, bool[] visited, int start, int r, List<int> result)
    {
        if (r == 0)
        {
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                if (visited[i]) sum += list[i];
            }
            result.Add(sum);
            return;
        }

        for (int i = start; i < list.Length; i++)
        {
            visited[i] = true;
            Combination(list, visited, i+1, r-1, result);
            visited[i] = false;
        }
    }
}