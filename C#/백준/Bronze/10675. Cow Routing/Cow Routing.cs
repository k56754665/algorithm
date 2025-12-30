using System;

class Program {
    public static void Main(string[] args) {
        int[] line1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int a = line1[0];
        int b = line1[1];
        int n = line1[2];

        int minCost = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            int[] line2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int cost = line2[0];

            int[] cities = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            bool isStarted = false;
            bool isArrived = false;
            foreach (int city in cities)
            {
                if (city == a) isStarted = true;
                if (isStarted && city == b) isArrived = true;
            }

            if (isArrived && minCost > cost) minCost = cost;
        }

        if (minCost >= int.MaxValue) minCost = -1;

        Console.WriteLine(minCost);
    }
}