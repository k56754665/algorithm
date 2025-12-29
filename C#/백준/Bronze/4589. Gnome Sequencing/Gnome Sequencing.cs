using System;
using System.Linq;

class Program {
    public static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Gnomes:");
        for (int i = 0; i < n; i++)
        {
            Solve();
        }
    }

    public static void Solve()
    {
        int[] group = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        bool asc = true;
        bool desc = true;

        for (int i = 0; i < group.Length - 1; i++)
        {
            if (group[i] >= group[i+1]) asc = false;
            if (group[i] <= group[i+1]) desc = false;

            if (!asc && !desc) break;
        }

        if (asc || desc) Console.WriteLine("Ordered");
        else Console.WriteLine("Unordered");
    }
}